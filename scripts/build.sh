#!/bin/bash
# com.mycompany.myapp - is app bundle identifier

# /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool --help

echo "build the iOS library (can also be build from Xamarin Studio)"

/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool -v build "--configuration:Release|iPhone" "../Crittercism.iOS/Crittercism.iOS.sln"

echo "build the android library (can also be build from Xamarin Studio) "

/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool -v build "--configuration:Release|Android" "../Crittercism.iOS/Android.iOS.sln"

echo "copy dll's to the component/bin folder"

#iOS Libraries
cp ../Crittercism.iOS/CrittercismXam/bin/Release/CrittercismXam.dll ../component/bin
cp ../Crittercism.iOS/CrittercismXam/bin/Release/Crittercism.dll ../component/bin

#Android Libraries
cp ../Crittercism.Android/Crittercism.Android/bin/Release/Crittercism.Android.dll ../component/bin/

echo "done, run '../component/rake' to build the component"

