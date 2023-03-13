##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=PleaseWork
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/Users/milowilson/Documents/Homework3
ProjectPath            :=/Users/milowilson/Documents/Homework3/PleaseWork
IntermediateDirectory  :=../build-$(ConfigurationName)/PleaseWork
OutDir                 :=../build-$(ConfigurationName)/PleaseWork
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Milo Wilson
Date                   :=23/09/2020
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
Objects0=../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/PleaseWork/main.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/PleaseWork/.d $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/PleaseWork"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/PleaseWork"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/PleaseWork/.d:
	@mkdir -p "../build-$(ConfigurationName)/PleaseWork"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(ObjectSuffix): LinkedList.cpp ../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/PleaseWork/LinkedList.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/LinkedList.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(DependSuffix): LinkedList.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(DependSuffix) -MM LinkedList.cpp

../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(PreprocessSuffix): LinkedList.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/PleaseWork/LinkedList.cpp$(PreprocessSuffix) LinkedList.cpp

../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(ObjectSuffix): Nodes.cpp ../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/PleaseWork/Nodes.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/Nodes.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(DependSuffix): Nodes.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(DependSuffix) -MM Nodes.cpp

../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(PreprocessSuffix): Nodes.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/PleaseWork/Nodes.cpp$(PreprocessSuffix) Nodes.cpp

../build-$(ConfigurationName)/PleaseWork/main.cpp$(ObjectSuffix): main.cpp ../build-$(ConfigurationName)/PleaseWork/main.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/PleaseWork/main.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/PleaseWork/main.cpp$(DependSuffix): main.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/PleaseWork/main.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/PleaseWork/main.cpp$(DependSuffix) -MM main.cpp

../build-$(ConfigurationName)/PleaseWork/main.cpp$(PreprocessSuffix): main.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/PleaseWork/main.cpp$(PreprocessSuffix) main.cpp


-include ../build-$(ConfigurationName)/PleaseWork//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


