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
include tests/CMakeFiles/parse_with_opts.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include tests/CMakeFiles/parse_with_opts.dir/compiler_depend.make

# Include the progress variables for this target.
include tests/CMakeFiles/parse_with_opts.dir/progress.make

# Include the compile flags for this target's objects.
include tests/CMakeFiles/parse_with_opts.dir/flags.make

tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj: tests/CMakeFiles/parse_with_opts.dir/flags.make
tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj: C:/Users/carlo/OneDrive/Documentos/QtProjects/ConsumeRESTfulAPI/C-CLI-storage/3rdparty/cJSON/tests/parse_with_opts.c
tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj: tests/CMakeFiles/parse_with_opts.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building C object tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -MD -MT tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj -MF CMakeFiles\parse_with_opts.dir\parse_with_opts.c.obj.d -o CMakeFiles\parse_with_opts.dir\parse_with_opts.c.obj -c C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\parse_with_opts.c

tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing C source to CMakeFiles/parse_with_opts.dir/parse_with_opts.c.i"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -E C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\parse_with_opts.c > CMakeFiles\parse_with_opts.dir\parse_with_opts.c.i

tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling C source to assembly CMakeFiles/parse_with_opts.dir/parse_with_opts.c.s"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && C:\Qt\Tools\mingw1120_64\bin\gcc.exe $(C_DEFINES) $(C_INCLUDES) $(C_FLAGS) -S C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests\parse_with_opts.c -o CMakeFiles\parse_with_opts.dir\parse_with_opts.c.s

# Object files for target parse_with_opts
parse_with_opts_OBJECTS = \
"CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj"

# External object files for target parse_with_opts
parse_with_opts_EXTERNAL_OBJECTS =

tests/parse_with_opts.exe: tests/CMakeFiles/parse_with_opts.dir/parse_with_opts.c.obj
tests/parse_with_opts.exe: tests/CMakeFiles/parse_with_opts.dir/build.make
tests/parse_with_opts.exe: libcjson.dll.a
tests/parse_with_opts.exe: tests/libunity.a
tests/parse_with_opts.exe: tests/CMakeFiles/parse_with_opts.dir/linklibs.rsp
tests/parse_with_opts.exe: tests/CMakeFiles/parse_with_opts.dir/objects1.rsp
tests/parse_with_opts.exe: tests/CMakeFiles/parse_with_opts.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking C executable parse_with_opts.exe"
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && $(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\parse_with_opts.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
tests/CMakeFiles/parse_with_opts.dir/build: tests/parse_with_opts.exe
.PHONY : tests/CMakeFiles/parse_with_opts.dir/build

tests/CMakeFiles/parse_with_opts.dir/clean:
	cd /d C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests && $(CMAKE_COMMAND) -P CMakeFiles\parse_with_opts.dir\cmake_clean.cmake
.PHONY : tests/CMakeFiles/parse_with_opts.dir/clean

tests/CMakeFiles/parse_with_opts.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\tests C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests C:\Users\carlo\OneDrive\Documentos\QtProjects\ConsumeRESTfulAPI\C-CLI-storage\3rdparty\cJSON\output\tests\CMakeFiles\parse_with_opts.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : tests/CMakeFiles/parse_with_opts.dir/depend

