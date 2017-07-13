#Xamarin Security - Vulnerable App:
--------------------------------------------------------------------------------------------------------------------------------------

Xamarin Cross Platform App - currently Android only - which imports two vulnerable libraries:  
    1. System.Net.Security: 4.3.0  
    2. Square.OkHTTP3: 3.0.1

Checking vulnerabilities using OWASP dependency-check and SafeNuGet.

--------------------------------------------------------------------------------------------------------------------------------------

Steps to install / run solution:

1. Import the solution to a Xamarin / C# compatible IDE (i.e. Visual Studio / Xamarin Studio)
2. Build the solution.
3. Deploy the solution via the deploy option within the IDE directly to an Android device or emulator.
4. You can now locate the APK file (by default located in /bin/debug or /bin/release) which can then be downloaded / installed on any compatible Android device.

**Note: As this is a Xamarin based application, some steps must be taken if you want to produce a generic Android compatible APK that you can install on any (compatible) Android device.

Steps to enable usable APK:
1. Right click Xam_Sec.Android and select the "Properties" option.
2. In the left pane, select the "Android Options" tab.
3. Untick the "Use Shared Runtime" option.

The "Use Shared Runtime" option is for speeding up debugging deployment only as it results in the IDE loading shared resources (i.e. core Xamarin.Android components) into a separate package which is used by the application.

More info can be found here: https://developer.xamarin.com/guides/android/advanced_topics/application_package_sizes/

--------------------------------------------------------------------------------------------------------------------------------------

Alternatively: Download the APK directly from https://github.com/DimSim101/Xam-Sec/blob/master/Xam-Sec/Xam_Sec.Android/bin/Debug/Xam_Sec.Android-Signed.apk and install directly to a compatible Android device.

--------------------------------------------------------------------------------------------------------------------------------------

Links / Sources:

- OWASP Tools:
    + https://www.owasp.org/index.php/OWASP_Dependency_Check
    + http://docs.myget.org/docs/how-to/checking-nuget-package-vulnerabilities-with-owasp-safenuget

- CVE's:

    + https://github.com/aspnet/Announcements/issues/239

    + http://www.cvedetails.com/cve/CVE-2016-2402/

    + http://docs.myget.org/docs/how-to/checking-nuget-package-vulnerabilities-with-owasp-safenuget

