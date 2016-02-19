#!/bin/bash

echo "You must manually build the iOS and Android components from Xamarin Studio."
echo "Did you do this? [y/n]"

read answer
if [ ${answer} != "y" ]; then
  exit 1;
fi

echo "clean the old bin files"
rm -rf component/bin

echo "copy dll's to the component/bin folder"
mkdir component/bin

IOS_BINDING=Crittercism.iOS/Crittercism.iOS/bin/Release/Crittercism.iOS.dll
ANDROID_BINDING=Crittercism.Android/Crittercism.Android/bin/Release/Crittercism.Android.dll

# Update the sample app with the latest binding
cp ${IOS_BINDING} samples/CrittercismSample.iOS/Sample.iOS/lib/
cp ${ANDROID_BINDING} samples/CrittercismSample.Android/CrittercismSample.Android/lib/

# Remove the contents of the sample app's components directory. This will get repopulated by
# Xamarin Studio when the sample app is compiled
rm -rf samples/CrittercismSample.iOS/Components/*

# Put the latest bindings in a location where we will later zip them up
cp ${IOS_BINDING} component/bin/
cp ${ANDROID_BINDING} component/bin/

cd component;

rake

cd ..


echo You should now upload the .xam file in to the Xamarin component store

ls component/*.xam

