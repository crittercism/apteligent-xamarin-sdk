# Xamarin Crittercism Component

Xamarin Crittercism Component

To build this component:

# Use Xamarin Studio to do "Release" builds of all projects
#in Crittercism.Workspace/Crittercism.mdw .

# Run scripts/build.sh while connected to the scripts directory
#to get *.dll's copied to file locations where rake with Rakefile
#will expect to find them.
cd scripts
sh build.sh

```shell
# Download xpkg
cd component
curl -L https://components.xamarin.com/submit/xpkg > xpkg.zip
mkdir xpkg
unzip -o -d xpkg xpkg.zip

# Create the component package
#update the version in RakeFile COMPONENT = "crittercism-X.X.xam"
cd component
rm -rf crittercism-X.X.xam
rake
```
