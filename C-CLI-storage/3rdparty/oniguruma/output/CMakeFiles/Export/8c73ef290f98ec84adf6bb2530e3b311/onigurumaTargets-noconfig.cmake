#----------------------------------------------------------------
# Generated CMake target import file.
#----------------------------------------------------------------

# Commands may need to know the format version.
set(CMAKE_IMPORT_FILE_VERSION 1)

# Import target "oniguruma::onig" for configuration ""
set_property(TARGET oniguruma::onig APPEND PROPERTY IMPORTED_CONFIGURATIONS NOCONFIG)
set_target_properties(oniguruma::onig PROPERTIES
  IMPORTED_IMPLIB_NOCONFIG "${_IMPORT_PREFIX}/lib/libonig.dll.a"
  IMPORTED_LOCATION_NOCONFIG "${_IMPORT_PREFIX}/bin/libonig.dll"
  )

list(APPEND _cmake_import_check_targets oniguruma::onig )
list(APPEND _cmake_import_check_files_for_oniguruma::onig "${_IMPORT_PREFIX}/lib/libonig.dll.a" "${_IMPORT_PREFIX}/bin/libonig.dll" )

# Commands beyond this point should not need to know the version.
set(CMAKE_IMPORT_FILE_VERSION)
