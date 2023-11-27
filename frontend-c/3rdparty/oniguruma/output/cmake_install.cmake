# Install script for directory: C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma

# Set the install prefix
if(NOT DEFINED CMAKE_INSTALL_PREFIX)
  set(CMAKE_INSTALL_PREFIX "C:/Program Files (x86)/oniguruma")
endif()
string(REGEX REPLACE "/$" "" CMAKE_INSTALL_PREFIX "${CMAKE_INSTALL_PREFIX}")

# Set the install configuration name.
if(NOT DEFINED CMAKE_INSTALL_CONFIG_NAME)
  if(BUILD_TYPE)
    string(REGEX REPLACE "^[^A-Za-z0-9_]+" ""
           CMAKE_INSTALL_CONFIG_NAME "${BUILD_TYPE}")
  else()
    set(CMAKE_INSTALL_CONFIG_NAME "")
  endif()
  message(STATUS "Install configuration: \"${CMAKE_INSTALL_CONFIG_NAME}\"")
endif()

# Set the component getting installed.
if(NOT CMAKE_INSTALL_COMPONENT)
  if(COMPONENT)
    message(STATUS "Install component: \"${COMPONENT}\"")
    set(CMAKE_INSTALL_COMPONENT "${COMPONENT}")
  else()
    set(CMAKE_INSTALL_COMPONENT)
  endif()
endif()

# Is this installation the result of a crosscompile?
if(NOT DEFINED CMAKE_CROSSCOMPILING)
  set(CMAKE_CROSSCOMPILING "FALSE")
endif()

# Set default install directory permissions.
if(NOT DEFINED CMAKE_OBJDUMP)
  set(CMAKE_OBJDUMP "C:/Qt/Tools/mingw1120_64/bin/objdump.exe")
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib" TYPE STATIC_LIBRARY OPTIONAL FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/libonig.dll.a")
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/bin" TYPE SHARED_LIBRARY FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/libonig.dll")
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/bin/libonig.dll" AND
     NOT IS_SYMLINK "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/bin/libonig.dll")
    if(CMAKE_INSTALL_DO_STRIP)
      execute_process(COMMAND "C:/Qt/Tools/mingw1120_64/bin/strip.exe" "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/bin/libonig.dll")
    endif()
  endif()
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/include" TYPE FILE FILES
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/src/oniguruma.h"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/src/oniggnu.h"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma" TYPE FILE FILES
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/generated/onigurumaConfig.cmake"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/generated/onigurumaConfigVersion.cmake"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  if(EXISTS "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma/onigurumaTargets.cmake")
    file(DIFFERENT _cmake_export_file_changed FILES
         "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma/onigurumaTargets.cmake"
         "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/CMakeFiles/Export/8c73ef290f98ec84adf6bb2530e3b311/onigurumaTargets.cmake")
    if(_cmake_export_file_changed)
      file(GLOB _cmake_old_config_files "$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma/onigurumaTargets-*.cmake")
      if(_cmake_old_config_files)
        string(REPLACE ";" ", " _cmake_old_config_files_text "${_cmake_old_config_files}")
        message(STATUS "Old export file \"$ENV{DESTDIR}${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma/onigurumaTargets.cmake\" will be replaced.  Removing files [${_cmake_old_config_files_text}].")
        unset(_cmake_old_config_files_text)
        file(REMOVE ${_cmake_old_config_files})
      endif()
      unset(_cmake_old_config_files)
    endif()
    unset(_cmake_export_file_changed)
  endif()
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma" TYPE FILE FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/CMakeFiles/Export/8c73ef290f98ec84adf6bb2530e3b311/onigurumaTargets.cmake")
  if(CMAKE_INSTALL_CONFIG_NAME MATCHES "^()$")
    file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/cmake/oniguruma" TYPE FILE FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/CMakeFiles/Export/8c73ef290f98ec84adf6bb2530e3b311/onigurumaTargets-noconfig.cmake")
  endif()
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/share/doc/onig" TYPE FILE FILES
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/API"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/API.ja"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/RE"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/RE.ja"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/FAQ"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/FAQ.ja"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/CALLOUTS.BUILTIN"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/CALLOUTS.BUILTIN.ja"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/CALLOUTS.API"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/CALLOUTS.API.ja"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/doc/UNICODE_PROPERTIES"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/share/doc/onig" TYPE FILE FILES
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/AUTHORS"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/COPYING"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/HISTORY"
    "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/README.md"
    )
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/lib/pkgconfig" TYPE FILE FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/oniguruma.pc")
endif()

if(CMAKE_INSTALL_COMPONENT STREQUAL "Unspecified" OR NOT CMAKE_INSTALL_COMPONENT)
  file(INSTALL DESTINATION "${CMAKE_INSTALL_PREFIX}/bin" TYPE PROGRAM FILES "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/onig-config")
endif()

if(NOT CMAKE_INSTALL_LOCAL_ONLY)
  # Include the install script for each subdirectory.
  include("C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/test/cmake_install.cmake")
  include("C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/windows/cmake_install.cmake")

endif()

if(CMAKE_INSTALL_COMPONENT)
  set(CMAKE_INSTALL_MANIFEST "install_manifest_${CMAKE_INSTALL_COMPONENT}.txt")
else()
  set(CMAKE_INSTALL_MANIFEST "install_manifest.txt")
endif()

string(REPLACE ";" "\n" CMAKE_INSTALL_MANIFEST_CONTENT
       "${CMAKE_INSTALL_MANIFEST_FILES}")
file(WRITE "C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/output/${CMAKE_INSTALL_MANIFEST}"
     "${CMAKE_INSTALL_MANIFEST_CONTENT}")
