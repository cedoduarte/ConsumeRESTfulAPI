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
CMAKE_SOURCE_DIR = C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output

# Include any dependencies generated for this target.
include test/CMakeFiles/test_syntax.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include test/CMakeFiles/test_syntax.dir/compiler_depend.make

# Include the progress variables for this target.
include test/CMakeFiles/test_syntax.dir/progress.make

# Include the compile flags for this target's objects.
include test/CMakeFiles/test_syntax.dir/flags.make

test/CMakeFiles/test_syntax.dir/test_syntax.c.obj: test/CMakeFiles/test_syntax.dir/flags.make
test/CMakeFiles/test_syntax.dir/test_syntax.c.obj: test/CMakeFiles/test_syntax.dir/includes_C.rsp
test/CMakeFiles/test_syntax.dir/test_syntax.c.obj: C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/test/test_syntax.c
test/CMakeFiles/test_syntax.dir/test_syntax.c.obj: test/CMakeFiles/test_syntax.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building C object test/CMakeFiles/test_syntax.dir/test_syntax.c.obj"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -MD -MT test/CMakeFiles/test_syntax.dir/test_syntax.c.obj -MF CMakeFiles\test_syntax.dir\test_syntax.c.obj.d -o CMakeFiles\test_syntax.dir\test_syntax.c.obj -c C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\test_syntax.c

test/CMakeFiles/test_syntax.dir/test_syntax.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/test_syntax.dir/test_syntax.c.i"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\test_syntax.c > CMakeFiles\test_syntax.dir\test_syntax.c.i

test/CMakeFiles/test_syntax.dir/test_syntax.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/test_syntax.dir/test_syntax.c.s"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\test_syntax.c -o CMakeFiles\test_syntax.dir\test_syntax.c.s

# Object files for target test_syntax
test_syntax_OBJECTS = \
"CMakeFiles/test_syntax.dir/test_syntax.c.obj"

# External object files for target test_syntax
test_syntax_EXTERNAL_OBJECTS =

test/test_syntax.exe: test/CMakeFiles/test_syntax.dir/test_syntax.c.obj
test/test_syntax.exe: test/CMakeFiles/test_syntax.dir/build.make
test/test_syntax.exe: libonig.dll.a
test/test_syntax.exe: test/CMakeFiles/test_syntax.dir/linklibs.rsp
test/test_syntax.exe: test/CMakeFiles/test_syntax.dir/objects1.rsp
test/test_syntax.exe: test/CMakeFiles/test_syntax.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking C executable test_syntax.exe"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\test_syntax.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
test/CMakeFiles/test_syntax.dir/build: test/test_syntax.exe
.PHONY : test/CMakeFiles/test_syntax.dir/build

test/CMakeFiles/test_syntax.dir/clean:
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && $(CMAKE_COMMAND) -P CMakeFiles\test_syntax.dir\cmake_clean.cmake
.PHONY : test/CMakeFiles/test_syntax.dir/clean

test/CMakeFiles/test_syntax.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test\CMakeFiles\test_syntax.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : test/CMakeFiles/test_syntax.dir/depend

