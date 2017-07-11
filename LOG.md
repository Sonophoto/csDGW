### 10-July-2017
#### Started Github repo for csDGW

#### Installed Mono framework via instructions at: [The Mono Project: Installation](http://www.mono-project.com/download/#download-lin-ubuntu)


    sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
    echo "deb http://download.mono-project.com/repo/ubuntu xenial main" | sudo tee /etc/apt/sources.list.d/mono-official.list
    sudo apt update    
    sudo apt upgrade
    sudo apt install mono-complete
    sudo apt install mono-dbg
    sudo apt install mono-

#### Tested installation by following build instructions at: [The Mono Project: Mono Basics](http://www.mono-project.com/docs/getting-started/mono-basics/)

##### Hello World
    ~/src/csDGW $ vi hello.cs
    ~/src/csDGW $ mcs hello.cs
    ~/src/csDGW $ mono hello.exe
    Hello Mono World

##### HTTPS Test:
[Download tlstest.cs](https://raw.github.com/mono/mono/master/mcs/class/Mono.Security/Test/tools/tlstest/tlstest.cs)

    ~/src/csDGW $ mcs tlstest.cs /r:System.dll /r:Mono.Security.dll
    tlstest.cs(169,23): warning CS0618: `System.Net.ServicePointManager.CertificatePolicy' is obsolete: `Use ServerCertificateValidationCallback instead'
    tlstest.cs(199,26): warning CS0618: `System.Net.Dns.Resolve(string)' is obsolete: `Use GetHostEntry instead'
    Compilation succeeded - 2 warning(s)
    
    ~/src/csDGW $ mono tlstest.exe https://www.nuget.org

    https://www.nuget.org
    
##### Winforms Test:
    ~/src/csDGW $ vi hello-winforms.cs
    ~/src/csDGW $ mcs hello-winforms.cs -pkg:dotnet
    ~/src/csDGW $ mono hello-winforms.exe 
    ~/src/csDGW $  [ DREW GUI WINDOW WITH TITLE: "Hello Mono World" ]
    
##### GTK-Sharp Test: (...Installed libraries for GTK#)
    ~/src/csDGW $ vi Hello_GTK_World.cs 
    ~/src/csDGW $ mcs Hello_GTK_World.cs -pkg:gtk-sharp-2.0
    ~/src/csDGW $ mono Hello_GTK_World.exe
    ~/src/csDGW $  [ DREW GTK WINDOW WITH TITLE: "Hello GTK World" ]
    
Mono Project system appears to be installed normally with possible exception of TLS/HTTPS test may need to be updated with current API. Added a bug to the repo this issue.

#### References on C#:
[C# Tutorial at Tutorials Point](https://www.tutorialspoint.com/csharp/index.htm)

[The Mono Project: Getting Started](http://www.mono-project.com/docs/getting-started/)



