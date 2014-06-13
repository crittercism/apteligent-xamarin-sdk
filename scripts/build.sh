
#!/bin/bash
# com.mycompany.myapp - is app bundle identifier

# /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool --help

# Manually build libraries ... if enterprise uncomment below for CLI build

#echo "build the iOS library (can also be build from Xamarin Studio)"
# /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool -v build "--configuration:Release|iPhone" "../Crittercism.iOS/Crittercism.iOS.sln"

# echo "build the android library (can also be build from Xamarin Studio) "
# /Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool -v build "--configuration:Release|Android" "../Crittercism.iOS/Android.iOS.sln"


echo "clean the old bin files"
rm -rf ../component/bin

echo "copy dll's to the component/bin folder"

mkdir ../component/bin/

#iOS Libraries
cp ../Crittercism.iOS/CrittercismSDK/bin/Release/Crittercism.iOS.dll ../component/bin/

#Android Libraries
cp ../Crittercism.Android/Crittercism.Android/bin/Release/Crittercism.Android.dll ../component/bin/

echo "done, run '../component/ and then rake' to build the component"
