# JE

This is an interpreter for the language I have made called JE(Jump Everything)


## Core Features

Base Features
- Data managment
- garbage collection
- the JP command
- conditionals
- Sheets (Basic Data Structures)


### Creating a new instance of JE code
```csharp
base_runner InstanceName = new base_runner(string code, Data bottom_data_layer, string local_path);
```


### Creating a new Data sheet outside of JE code
```csharp
Data data_layer_name = new Data();
```


### Packages for JE
using the useC and use commands developers are able to add aditional packages.
some basic packages can be found on the github page https://github.com/Ethmon/JE-imports.git
- useC for code packages
- use for instantiation packages

### Jumping
in JE there is a special command called jump or jp for short.  jp is a flow controll command that lets you put the pointer of which line the interpeter is on to other lines
taging is an integral part of jumping and a taged line looks like this: '>> tag' where tag is the tags name.
an example of this would be '>> function1' which would be a tag for 'function1'
The 5 types of jumping are
- Variable jumping: this allows you to jump to a line with the numerical value of the variable in front of it
- Numerical jumping: this allows you to specify a line with a number and jump to that line
- Taged jumping: finds the first line in the program that has the specified tag. to call this use 'jp >> {called tag}'.
- forward taged jumping: finds the next line that has the specified tag. to call this use 'jp -> {called tag}'
- backwards taged jumping: finds the closest line that has the specified tag that is not greater than the current line number. to call this use 'jp <- {called tag}'

## License
MIT License - See LICENSE file for details

## Contact
Ethan
- GitHub: TEthmon
- Email: Ethan6Salu@gmail.com


Built with C# and a passion for learning from scratch.
