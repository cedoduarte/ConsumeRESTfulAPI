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
include test/CMakeFiles/testcu.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include test/CMakeFiles/testcu.dir/compiler_depend.make

# Include the progress variables for this target.
include test/CMakeFiles/testcu.dir/progress.make

# Include the compile flags for this target's objects.
include test/CMakeFiles/testcu.dir/flags.make

test/CMakeFiles/testcu.dir/testu.c.obj: test/CMakeFiles/testcu.dir/flags.make
test/CMakeFiles/testcu.dir/testu.c.obj: test/CMakeFiles/testcu.dir/includes_C.rsp
test/CMakeFiles/testcu.dir/testu.c.obj: C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-frontend/3rdparty/oniguruma/test/testu.c
test/CMakeFiles/testcu.dir/testu.c.obj: test/CMakeFiles/testcu.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building C object test/CMakeFiles/testcu.dir/testu.c.obj"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -MD -MT test/CMakeFiles/testcu.dir/testu.c.obj -MF CMakeFiles\testcu.dir\testu.c.obj.d -o CMakeFiles\testcu.dir\testu.c.obj -c C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\testu.c

test/CMakeFiles/testcu.dir/testu.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/testcu.dir/testu.c.i"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\testu.c > CMakeFiles\testcu.dir\testu.c.i

test/CMakeFiles/testcu.dir/testu.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/testcu.dir/testu.c.s"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test\testu.c -o CMakeFiles\testcu.dir\testu.c.s

# Object files for target testcu
testcu_OBJECTS = \
"CMakeFiles/testcu.dir/testu.c.obj"

# External object files for target testcu
testcu_EXTERNAL_OBJECTS =

test/testcu.exe: test/CMakeFiles/testcu.dir/testu.c.obj
test/testcu.exe: test/CMakeFiles/testcu.dir/build.make
test/testcu.exe: libonig.dll.a
test/testcu.exe: test/CMakeFiles/testcu.dir/linklibs.rsp
test/testcu.exe: test/CMakeFiles/testcu.dir/objects1.rsp
test/testcu.exe: test/CMakeFiles/testcu.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking C executable testcu.exe"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\testcu.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
test/CMakeFiles/testcu.dir/build: test/testcu.exe
.PHONY : test/CMakeFiles/testcu.dir/build

test/CMakeFiles/testcu.dir/clean:
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test && $(CMAKE_COMMAND) -P CMakeFiles\testcu.dir\cmake_clean.cmake
.PHONY : test/CMakeFiles/testcu.dir/clean

test/CMakeFiles/testcu.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\test C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-frontend\3rdparty\oniguruma\output\test\CMakeFiles\testcu.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : test/CMakeFiles/testcu.dir/depend

