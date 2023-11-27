cmake_minimum_required(VERSION 3.5)

project(ConsumeRESTfulAPI LANGUAGES C)

set(PROJECT_FILES
    main.c
    application.c
    application.h
    local_storage.c
    local_storage.h
    database.c
    database.h
    utils/regular_expression.c
    utils/regular_expression.h
    utils/restful.c
    utils/restful.h
    utils/sha256.c
    utils/sha256.h
    utils/sqlite3.c
    utils/sqlite3.h
    utils/util_string.c
    utils/util_string.h
)

set(LIBS_DIR
    ../../3rdparty/curl/output/lib
    ../../3rdparty/oniguruma/output
    ../../3rdparty/cJSON/output
    "C:/Program Files/MariaDB 11.0/lib"
)

set(INCLUDE_DIRS
    ../../3rdparty/curl/include
    ../../3rdparty/oniguruma/src
    ../../3rdparty/cJSON
    "C:/Program Files/MariaDB 11.0/include"
)

# create executable
add_executable(ConsumeRESTfulAPI ${PROJECT_FILES})

# include directories
target_include_directories(ConsumeRESTfulAPI PRIVATE ${INCLUDE_DIRS})

# link directories
target_link_directories(ConsumeRESTfulAPI PRIVATE ${LIBS_DIR})

# curl link library
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcurl)

# oniguruma link library
target_link_libraries(ConsumeRESTfulAPI PRIVATE libonig)

# cJSON link library
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcjson)

# mariadb link lbrary
target_link_libraries(ConsumeRESTfulAPI PRIVATE libmariadb)

install(TARGETS ConsumeRESTfulAPI
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)
