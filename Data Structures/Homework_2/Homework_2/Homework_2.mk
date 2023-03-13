##
## Auto Generated makefile by CodeLite IDE
## any manual changes will be erased      
##
## Debug
ProjectName            :=Homework_2
ConfigurationName      :=Debug
WorkspaceConfiguration := $(ConfigurationName)
WorkspacePath          :=/Users/milowilson/Documents/Homework_2
ProjectPath            :=/Users/milowilson/Documents/Homework_2/Homework_2
IntermediateDirectory  :=../build-$(ConfigurationName)/Homework_2
OutDir                 :=../build-$(ConfigurationName)/Homework_2
CurrentFileName        :=
CurrentFilePath        :=
CurrentFileFullPath    :=
User                   :=Milo Wilson
Date                   :=15/09/2020
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
Objects0=../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(ObjectSuffix) ../build-$(ConfigurationName)/Homework_2/main.cpp$(ObjectSuffix) 



Objects=$(Objects0) 

##
## Main Build Targets 
##
.PHONY: all clean PreBuild PrePreBuild PostBuild MakeIntermediateDirs
all: MakeIntermediateDirs $(OutputFile)

$(OutputFile): ../build-$(ConfigurationName)/Homework_2/.d $(Objects) 
	@mkdir -p "../build-$(ConfigurationName)/Homework_2"
	@echo "" > $(IntermediateDirectory)/.d
	@echo $(Objects0)  > $(ObjectsFileList)
	$(LinkerName) $(OutputSwitch)$(OutputFile) @$(ObjectsFileList) $(LibPath) $(Libs) $(LinkOptions)

MakeIntermediateDirs:
	@mkdir -p "../build-$(ConfigurationName)/Homework_2"
	@mkdir -p ""../build-$(ConfigurationName)/bin""

../build-$(ConfigurationName)/Homework_2/.d:
	@mkdir -p "../build-$(ConfigurationName)/Homework_2"

PreBuild:


##
## Objects
##
../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(ObjectSuffix): TicTacToe.cpp ../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework_2/Homework_2/TicTacToe.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/TicTacToe.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(DependSuffix): TicTacToe.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(DependSuffix) -MM TicTacToe.cpp

../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(PreprocessSuffix): TicTacToe.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Homework_2/TicTacToe.cpp$(PreprocessSuffix) TicTacToe.cpp

../build-$(ConfigurationName)/Homework_2/main.cpp$(ObjectSuffix): main.cpp ../build-$(ConfigurationName)/Homework_2/main.cpp$(DependSuffix)
	$(CXX) $(IncludePCH) $(SourceSwitch) "/Users/milowilson/Documents/Homework_2/Homework_2/main.cpp" $(CXXFLAGS) $(ObjectSwitch)$(IntermediateDirectory)/main.cpp$(ObjectSuffix) $(IncludePath)
../build-$(ConfigurationName)/Homework_2/main.cpp$(DependSuffix): main.cpp
	@$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) -MG -MP -MT../build-$(ConfigurationName)/Homework_2/main.cpp$(ObjectSuffix) -MF../build-$(ConfigurationName)/Homework_2/main.cpp$(DependSuffix) -MM main.cpp

../build-$(ConfigurationName)/Homework_2/main.cpp$(PreprocessSuffix): main.cpp
	$(CXX) $(CXXFLAGS) $(IncludePCH) $(IncludePath) $(PreprocessOnlySwitch) $(OutputSwitch) ../build-$(ConfigurationName)/Homework_2/main.cpp$(PreprocessSuffix) main.cpp


-include ../build-$(ConfigurationName)/Homework_2//*$(DependSuffix)
##
## Clean
##
clean:
	$(RM) -r $(IntermediateDirectory)


