##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=Homework3
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/Users/milowilson/Documents/Homework3
ProjectPath            :=/Users/milowilson/Documents/Homework3/Homework3
IntermediateDirectory  :=../build-$(ConfigurationName)/Homework3
OutDir                 :=../build-$(ConfigurationName)/Homework3
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Milo Wilson
Date                   :=22/09/2020
CodeLitePath           :="/Users/milowilson/Library/Application Support/CodeLite"
LinkerName             :=/usr/bin/g++
SharedObjectLinkerName :=/usr/bin/g++ -dynamiclib -fPIC
ObjectSuffix           :=.o
DependSuffix           :=.o.d
PreprocessSuffix       :=.i
DebugSwitch            :=-g 
IncludeSwitch          :=-I
LibrarySwitch          :=-l
OutputSwitch           :=-o 
LibraryPathSwitch      :=-L
PreprocessorSwitch     :=-D
SourceSwitch           :=-c 
OutputFile             :=../build-$(ConfigurationName)/bin/$(ProjectName)
Preprocessors          :=
ObjectSwitch           :=-o 
ArchiveOutputSwitch    := 
PreprocessOnlySwitch   :=-E
ObjectsFileList        :=$(IntermediateDirectory)/ObjectsList.txt
PCHCompileFlags        :=
LinkOptions            :=  
IncludePath            :=  $(IncludeSwitch). $(IncludeSwitch). 
IncludePCH             := 
RcIncludePath          := 
Libs                   := 
ArLibs                 :=  
LibPath                := $(LibraryPathSwitch). 

##
## Common variables
## AR, CXX, CC, AS, CXXFLAGS and CFLAGS can be overriden using an environment variables
##
AR       := /usr/bin/ar rcu
CXX      := /usr/bin/g++
CC       := /usr/bin/gcc
CXXFLAGS :=  -g -O0 -Wall $(Preprocessors)
CFLAGS   :=  -g -O0 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := /usr/bin/as


##
## User defined environment variables
##
CodeLiteDir:=/private/var/folders/xb/6xyc4ljs0d30m8xj84hff24c0000gn/T/AppTranslocation/F86DA47C-3A36-41D6-9F08-089AED34615F/d/codelite.app/Contents/SharedSupport/
Objects0=../build-$(ConfigurationName)/Homework3/Node.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/Homework3/main.c$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/Homework3/.d $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/Homework3"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/Homework3"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/Homework3/.d:
	@mkdir -p "../build-$(ConfigurationName)/Homework3"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/Homework3/Node.cpp$(ObjectSuffix): Node.cpp ../build-$(ConfigurationName)/Homework3/Node.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/Homework3/Node.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/Node.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Homework3/Node.cpp$(DependSuffix): Node.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Homework3/Node.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/Homework3/Node.cpp$(DependSuffix) -MM Node.cpp

../build-$(ConfigurationName)/Homework3/Node.cpp$(PreprocessSuffix): Node.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Homework3/Node.cpp$(PreprocessSuffix) Node.cpp

../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(ObjectSuffix): LinkedList.cpp ../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/Homework3/LinkedList.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/LinkedList.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(DependSuffix): LinkedList.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(DependSuffix) -MM LinkedList.cpp

../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(PreprocessSuffix): LinkedList.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Homework3/LinkedList.cpp$(PreprocessSuffix) LinkedList.cpp

../build-$(ConfigurationName)/Homework3/main.c$(ObjectSuffix): main.c ../build-$(ConfigurationName)/Homework3/main.c$(DependSuffix)
	$(CC) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/Homework3/main.c" $(CFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main.c$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Homework3/main.c$(DependSuffix): main.c
	@$(CC) $(CFLAGS) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Homework3/main.c$(ObjectSuffix) -MF../build-$(ConfigurationName)/Homework3/main.c$(DependSuffix) -MM main.c

../build-$(ConfigurationName)/Homework3/main.c$(PreprocessSuffix): main.c
	$(CC) $(CFLAGS) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Homework3/main.c$(PreprocessSuffix) main.c


-include ../build-$(ConfigurationName)/Homework3//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


