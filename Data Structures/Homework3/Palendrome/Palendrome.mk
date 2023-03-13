##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=Palendrome
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/Users/milowilson/Documents/Homework3
ProjectPath            :=/Users/milowilson/Documents/Homework3/Palendrome
IntermediateDirectory  :=../build-$(ConfigurationName)/Palendrome
OutDir                 :=../build-$(ConfigurationName)/Palendrome
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
LinkOptions            :=  $(shell wx-config --libs) 
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
CXXFLAGS :=  -g -O0 -Wall $(shell wx-config --cxxflags)   $(Preprocessors)
CFLAGS   :=  -g -O0 -Wall $(Preprocessors)
ASFLAGS  := 
AS       := /usr/bin/as


##
## User defined environment variables
##
CodeLiteDir:=/private/var/folders/xb/6xyc4ljs0d30m8xj84hff24c0000gn/T/AppTranslocation/F86DA47C-3A36-41D6-9F08-089AED34615F/d/codelite.app/Contents/SharedSupport/
Objects0=../build-$(ConfigurationName)/Palendrome/main_app.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/Palendrome/.d $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/Palendrome"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/Palendrome"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/Palendrome/.d:
	@mkdir -p "../build-$(ConfigurationName)/Palendrome"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/Palendrome/main_app.cpp$(ObjectSuffix): main_app.cpp ../build-$(ConfigurationName)/Palendrome/main_app.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework3/Palendrome/main_app.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main_app.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Palendrome/main_app.cpp$(DependSuffix): main_app.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Palendrome/main_app.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/Palendrome/main_app.cpp$(DependSuffix) -MM main_app.cpp

../build-$(ConfigurationName)/Palendrome/main_app.cpp$(PreprocessSuffix): main_app.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Palendrome/main_app.cpp$(PreprocessSuffix) main_app.cpp


-include ../build-$(ConfigurationName)/Palendrome//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


