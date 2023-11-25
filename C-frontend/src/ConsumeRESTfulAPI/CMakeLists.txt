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
)

set(LIBS_DIR
    ../../3rdparty/curl/output/lib
    ../../3rdparty/oniguruma/output
    "C:/Program Files/MariaDB 11.0/lib"
    C:/msys64/mingw64/bin
)

set(INCLUDE_DIRS
    ../../3rdparty/curl/include
    ../../3rdparty/oniguruma/src
    "C:/Program Files/MariaDB 11.0/include"
    C:/msys64/mingw64/include/gtk-4.0
    C:/msys64/mingw64/include/pango-1.0
    C:/msys64/mingw64/include/glib-2.0
    C:/msys64/mingw64/include/harfbuzz
    C:/msys64/mingw64/include/cairo
    C:/msys64/mingw64/include/gdk-pixbuf-2.0
    C:/msys64/mingw64/include/graphene-1.0
    C:/msys64/mingw64/lib/graphene-1.0/include
    C:/msys64/mingw64/lib/glib-2.0/include
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

# mariadb link lbrary
target_link_libraries(ConsumeRESTfulAPI PRIVATE libmariadb)

# gtk+ 4.0 link libraries
target_link_libraries(ConsumeRESTfulAPI PRIVATE edit)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libasprintf-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libatomic-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libbrotlicommon)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libbrotlidec)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libbrotlienc)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libbz2-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcairo-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcairo-gobject-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcairo-script-interpreter-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcharset-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libcrypto-3-x64)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libdatrie-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libdeflate)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libepoxy-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libexpat-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libffi-8)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libfontconfig-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libformw6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libfreetype-6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libfribidi-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgcc_s_seh-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgdk_pixbuf-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgettextlib-0-21-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgettextpo-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgettextsrc-0-21-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgif-7)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgio-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libglib-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgmodule-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgobject-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgomp-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgraphene-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgraphite2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgthread-2.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libgtk-4-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libharfbuzz-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libharfbuzz-cairo-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libharfbuzz-gobject-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libharfbuzz-icu-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libharfbuzz-subset-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libhistory8)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libiconv-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libintl-8)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libjbig-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libjpeg-8)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libjson-glib-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libLerc)
target_link_libraries(ConsumeRESTfulAPI PRIVATE liblzma-5)
target_link_libraries(ConsumeRESTfulAPI PRIVATE liblzo2-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libmenuw6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libmpdec++-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libmpdec-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libncurses++w6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libncursesw6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpanelw6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpango-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpangocairo-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpangoft2-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpangowin32-1.0-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpcre2-8-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpcre2-16-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpcre2-32-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpcre2-posix-3)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpixman-1-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpng16-16)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpython3.11)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libpython3)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libquadmath-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libreadline8)
target_link_libraries(ConsumeRESTfulAPI PRIVATE librsvg-2-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libsharpyuv-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libsqlite3-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libssl-3-x64)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libstdc++-6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libsystre-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libtermcap-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libthai-0)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libtiff-6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libtiffxx-6)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libtre-5)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libturbojpeg)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libwebp-7)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libwebpdecoder-3)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libwebpdemux-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libwebpmux-3)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libwinpthread-1)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libxml2-2)
target_link_libraries(ConsumeRESTfulAPI PRIVATE libzstd)
target_link_libraries(ConsumeRESTfulAPI PRIVATE tcl86)
target_link_libraries(ConsumeRESTfulAPI PRIVATE tk86)
target_link_libraries(ConsumeRESTfulAPI PRIVATE zlib1)

install(TARGETS ConsumeRESTfulAPI
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBDIR}
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINDIR}
)
