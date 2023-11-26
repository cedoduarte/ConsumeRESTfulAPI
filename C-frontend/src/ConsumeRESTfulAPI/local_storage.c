#include "local_storage.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define DEFAULT_USER_COUNT 10

static int local_storage_execute_sql_with_no_data_return(sqlite3 *db,
                                                             const char *sql,
                                                             const char *succeedMessage)
{
    // Execute the SQL statement
    char *errMsg = NULL;
    const int rc = sqlite3_exec(db, sql, 0, 0, &errMsg);

    if (rc != SQLITE_OK)
    {
        fprintf(stderr, "SQL error: %s\n", errMsg);
        sqlite3_free(errMsg);
        return SQLITE_ERROR;
    }
    else
    {
        fprintf(stdout, succeedMessage);
    }
    return SQLITE_OK;
}

static int local_storage_create_user_table(sqlite3 *db)
{
    // SQL statement to create a table
    return local_storage_execute_sql_with_no_data_return(db, "CREATE TABLE IF NOT EXISTS user("
                                                             "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                                                             "name VARCHAR(256) NOT NULL,"
                                                             "email VARCHAR(256) NOT NULL,"
                                                             "password VARCHAR(1024) NOT NULL,"
                                                             "address VARCHAR(512) NOT NULL,"
                                                             "country VARCHAR(512) NOT NULL,"
                                                             "city VARCHAR(512) NOT NULL,"
                                                             "salary REAL NOT NULL,"
                                                             "is_deleted INTEGER DEFAULT 0,"
                                                             "inserted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "updated_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "deleted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "current_user INTEGER DEFAULT 1,"
                                                             "birthdate DATETIME NOT NULL"
                                                             ");", "Table created successfully\n");
}

static int local_storage_create_device_table(sqlite3 *db)
{
    // SQL statement to create a table
    return local_storage_execute_sql_with_no_data_return(db, "CREATE TABLE IF NOT EXISTS device("
                                                             "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                                                             "name VARCHAR(128) NOT NULL,"
                                                             "user_id INTEGER NOT NULL,"
                                                             "price REAL NOT NULL,"
                                                             "is_deleted INTEGER DEFAULT 0,"
                                                             "inserted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "updated_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "deleted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "current_user INTEGER DEFAULT 1"
                                                             ");", "Table created successfully\n");
}

static int local_storage_create_product_table(sqlite3 *db)
{
    // SQL statement to create a table
    return local_storage_execute_sql_with_no_data_return(db, "CREATE TABLE IF NOT EXISTS product("
                                                             "id INTEGER PRIMARY KEY AUTOINCREMENT,"
                                                             "name VARCHAR(128) NOT NULL,"
                                                             "price REAL NOT NULL,"
                                                             "quantity_in_stock INTEGER NOT NULL,"
                                                             "is_deleted INTEGER DEFAULT 0,"
                                                             "inserted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "updated_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "deleted_date_time DATETIME DEFAULT CURRENT_TIMESTAMP,"
                                                             "current_user INTEGER DEFAULT 1"
                                                             ");", "Table created successfully\n");
}

static int local_storage_seeding_default_users(sqlite3 *db)
{
    /*
    "root",       // administrator
    "cduarte",    // Carlos Enrique Duarte Ortiz
    "apena",      // Ana Lourdes Peña López
    "kozuna",     // Kévin Ozuna Pérez
    "jdominguez", // Javier Domínguez Rodríguez
    "gprado",     // Gabriel Prado Ramírez
    "osalazar",   // Óscar Salazar Ozuna
    "cmiranda",   // Christan Miranda Robles
    "rgracia",    // Rosa Gracia Juarez
    "cchavez"     // Carlos Chavez Guajardo
    */
    char *hashArray[DEFAULT_USER_COUNT] = {
        "4813494d137e1631bba31d5acab6e7bb7aa74ce1185d456565ef51d737677b2",  // root
        "51fed9a64af344048fc5728f64675d34c7876927a22bee96b2a4172285941d",   // cduarte
        "1fcd586d878e01b7fc94d5ba229fe5a3e228ec54df1638cecced6c9b4e1e",     // apena
        "6f2da887612fd03887bf669ccabf7b58f2e258958d0b7e544b25b86851a179",   // kozuna
        "bf2d11e63ec01d7118cfad367b6e84977d9ff45663cf1f921f744becdb14b4bd", // jdominguez
        "c2ad4783513ccdea0348e9faaf040a72b9f921a50792d9e28568498e752a27b",  // gprado
        "c5b532e0624611d7844fb55ddb87ba3d54064ee305f48d7f1af20af3ba7270",   // osalazar
        "c0fc82b78b770ce805896a139e76896161fb84b8958846978160f2d78f12",     // cmiranda
        "d2d44458d7c7ee3fe6966d8dac148546fd27f76f4e9cfca2fb55586e18c4330",  // rgracia
        "84ad9371989db9696823cf2496a158b6ec06b84af7ca73792f4a69d8936e7"     // cchavez
    };

    // SQL statement to insert data into the table
    char sql[3000];
    sprintf(sql, "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('root'                       ,'root@local'                ,'%s', '1995-2-15'  ,'none'                  ,'none'     ,'none'            ,0.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Carlos Enrique Duarte Ortiz','carlosduarte.1@hotmail.com','%s', '1995-3-25'  ,'Esperanza 1515'        ,'México'   ,'Hermosillo'      ,50000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Ana Lourdes Peña López'     ,'analourdes@hotmail.com'    ,'%s', '1995-4-5'   ,'Palermo 23'            ,'Argentina','Buenos Aires'    ,45000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Kévin Ozuna Pérez'          ,'kevinozuna@gmail.com'      ,'%s', '1995-5-6'   ,'Bachoco 45'            ,'México'   ,'Hermosillo'      ,55000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Javier Domínguez Rodríguez' ,'javierdomi@gmail.com'      ,'%s', '1995-6-7'   ,'Polanco 35'            ,'México'   ,'Ciudad de México',42000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Gabriel Prado Ramírez'      ,'gabryprado@hotmail.com'    ,'%s', '1995-7-8'   ,'Conquistadores 25'     ,'Colombia' ,'Bogotá'          ,36000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Óscar Salazar Ozuna'        ,'oscarsala@hotmail.com'     ,'%s', '1995-8-9'   ,'Simón Bolívar 78'      ,'Venezuela','Caracas'         ,19852.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Christian Miranda Robles'   ,'christianmira10@gmail.com' ,'%s', '1995-9-10'  ,'Mártires de Cananea 22','México'   ,'Hermosillo'      ,41000.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Rosa Grácia Juárez'         ,'rosagracia1@hotmail.com'   ,'%s', '1995-10-11' ,'Hacienda Cazadores 33' ,'México'   ,'Monterrey'       ,55200.0);"
                 "INSERT INTO user(name,email,password,birthdate,address,country,city,salary) VALUES('Carlos Chávez Guajardo'     ,'carloschavezg@gmail.com'   ,'%s', '1995-11-12' ,'República de Panamá 79','México'   ,'Hermosillo'      ,41000.0);",
            hashArray[0],
            hashArray[1],
            hashArray[2],
            hashArray[3],
            hashArray[4],
            hashArray[5],
            hashArray[6],
            hashArray[7],
            hashArray[8],
            hashArray[9]);
    return local_storage_execute_sql_with_no_data_return(db, sql, "Records created successfully\n");
}

static int local_storage_seeding_default_devices(sqlite3 *db)
{
    // SQL statement to insert data into the table
    return local_storage_execute_sql_with_no_data_return(db,
        "INSERT INTO device(name,user_id,price,current_user) VALUES('wiko T3',1,3000.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('wiko T10',2,6000.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('samsung X',3,4500.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('iPhone X',4,30000.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('motorola',5,5000.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('honor',6,3800.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('xiaomi',7,4568.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('realme',8,3900.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('huawei',9,4350.0,1);"
        "INSERT INTO device(name,user_id,price,current_user) VALUES('oppo',10,3000.0,1);",
                                                         "Records created successfully\n");
}

static int local_storage_seeding_default_products(sqlite3 *db)
{
    // SQL statement to insert data into the table
    return local_storage_execute_sql_with_no_data_return(db,
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Playstation 5',10500.0,200);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Nintendo Switch',7800.0,500);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('iPhone X',30000.0,700);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Huawei 8',10500.0,500);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('SmartWatch Android',10000.0,1000);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('HP Laptop',15000.0,55);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Dell Laptop',20000.0,120);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Xbox One',18000.0,35);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('SmartTV LG',32000.0,425);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('iMac Big Sur',20000.0,98);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('MacBook Air',40000.0,10);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Impresora EPSON',6000.0,300);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Mouse Microsoft',350.0,1000);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Teclado Microsoft',700.0,750);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Audífonos Sony',300.0,400);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Memoria USB Kingston',200.0,740);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Memoria USB DataTraveler',300.0,1000);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Micrófono Steren',400.0,600);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('NoBreak Steren',12000.0,300);"
        "INSERT INTO product(name,price,quantity_in_stock) VALUES('Scanner Canon',7000.0,100);",
                                                         "Records created successfully\n");
}

// Callback function to process the result of the SQL query
static int countCallback(void *data, int argc, char **argv, char **azColName)
{
    int *count = (int*)data;
    *count = atoi(argv[0]);
    return 0;
}

static int local_storage_get_table_total_record_count(sqlite3 *db, const char *tableName)
{
    // SQL query to select the count of users
    char sql[512];
    sprintf(sql, "SELECT COUNT(*) FROM %s", tableName);

    // Execute the SQL query
    int count = 0;
    char *errMsg = NULL;
    const int rc = sqlite3_exec(db, sql, countCallback, &count, &errMsg);

    if (rc != SQLITE_OK)
    {
        fprintf(stderr, "SQL error: %s\n", errMsg);
        sqlite3_free(errMsg);
    }
    else
    {
        printf("Count of %ss: %d\n", tableName, count);
    }
    return count;
}

int local_storage_migrate(sqlite3 *db)
{
    if (local_storage_create_user_table(db) != SQLITE_OK)
    {
        return SQLITE_ERROR;
    }
    if (local_storage_create_device_table(db) != SQLITE_OK)
    {
        return SQLITE_ERROR;
    }
    if (local_storage_create_product_table(db) != SQLITE_OK)
    {
        return SQLITE_ERROR;
    }
    return SQLITE_OK;
}

int local_storage_seeding_data(sqlite3 *db)
{
    // we only insert data if the current table has no any records
    if (local_storage_get_table_total_record_count(db, "user") == 0)
    {
        printf("local-storage: users count = 0\n");
        if (local_storage_seeding_default_users(db) != SQLITE_OK)
        {
            return SQLITE_ERROR;
        }
        else
        {
            printf("local-storage: users inserted!\n");
        }
    }
    else
    {
        printf("local-storage: user table already has records!\n");
    }
    if (local_storage_get_table_total_record_count(db, "device") == 0)
    {
        printf("local-storage: devices count = 0\n");
        if (local_storage_seeding_default_devices(db) != SQLITE_OK)
        {
            return SQLITE_ERROR;
        }
        else
        {
            printf("local-storage: devices inserted!\n");
        }
    }
    else
    {
        printf("local-storage: device table already has records!\n");
    }
    if (local_storage_get_table_total_record_count(db, "product") == 0)
    {
        printf("local-storage: products count = 0\n");
        if (local_storage_seeding_default_products(db) != SQLITE_OK)
        {
            return SQLITE_ERROR;
        }
        else
        {
            printf("local-storage: products inserted!\n");
        }
    }
    else
    {
        printf("local-storage: product table already has records!\n");
    }
    return SQLITE_OK;
}
