# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.24

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = C:\Qt\Tools\CMake_64\bin\cmake.exe

# The command to remove a file.
RM = C:\Qt\Tools\CMake_64\bin\cmake.exe -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output

# Include any dependencies generated for this target.
include tests/CMakeFiles/misc_tests.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include tests/CMakeFiles/misc_tests.dir/compiler_depend.make

# Include the progress variables for this target.
include tests/CMakeFiles/misc_tests.dir/progress.make

# Include the compile flags for this target's objects.
include tests/CMakeFiles/misc_tests.dir/flags.make

tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj: tests/CMakeFiles/misc_tests.dir/flags.make
tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj: C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-CLI-storage/3rdparty/cJSON/tests/misc_tests.c
tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj: tests/CMakeFiles/misc_tests.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building C object tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -MD -MT tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj -MF CMakeFiles\misc_tests.dir\misc_tests.c.obj.d -o CMakeFiles\misc_tests.dir\misc_tests.c.obj -c C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\misc_tests.c

tests/CMakeFiles/misc_tests.dir/misc_tests.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/misc_tests.dir/misc_tests.c.i"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\misc_tests.c > CMakeFiles\misc_tests.dir\misc_tests.c.i

tests/CMakeFiles/misc_tests.dir/misc_tests.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/misc_tests.dir/misc_tests.c.s"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\misc_tests.c -o CMakeFiles\misc_tests.dir\misc_tests.c.s

# Object files for target misc_tests
misc_tests_OBJECTS = \
"CMakeFiles/misc_tests.dir/misc_tests.c.obj"

# External object files for target misc_tests
misc_tests_EXTERNAL_OBJECTS =

tests/misc_tests.exe: tests/CMakeFiles/misc_tests.dir/misc_tests.c.obj
tests/misc_tests.exe: tests/CMakeFiles/misc_tests.dir/build.make
tests/misc_tests.exe: libcjson.dll.a
tests/misc_tests.exe: tests/libunity.a
tests/misc_tests.exe: tests/CMakeFiles/misc_tests.dir/linklibs.rsp
tests/misc_tests.exe: tests/CMakeFiles/misc_tests.dir/objects1.rsp
tests/misc_tests.exe: tests/CMakeFiles/misc_tests.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking C executable misc_tests.exe"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\misc_tests.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
tests/CMakeFiles/misc_tests.dir/build: tests/misc_tests.exe
.PHONY : tests/CMakeFiles/misc_tests.dir/build

tests/CMakeFiles/misc_tests.dir/clean:
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && $(CMAKE_COMMAND) -P CMakeFiles\misc_tests.dir\cmake_clean.cmake
.PHONY : tests/CMakeFiles/misc_tests.dir/clean

tests/CMakeFiles/misc_tests.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests\CMakeFiles\misc_tests.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : tests/CMakeFiles/misc_tests.dir/depend

