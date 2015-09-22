# Xamarin Crittercism Component

Xamarin Crittercism Component

To build this component:

```shell
# Download xpkg
curl -L https://components.xamarin.com/submit/xpkg > xpkg.zip
mkdir xpkg
unzip -o -d xpkg xpkg.zip

# Create the component package
#update the version in RakeFile COMPONENT = "crittercism-1.0.xam"
rm -rf crittercism-1.0.xam
rake
```
