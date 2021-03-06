# About GTASG

It is a tool that allows you to generate code for Sanny Builder using the modern `C#` programming language. Code generation occurs by converting existing methods into the equivalent of opcodes for the SCM script. Both regular code generation and direct compilation using Sanny Builder's CLI are supported.

![GTASG](http://ru-script.3dn.ru/_ld/6/08053124.png)

## Supported versions
| Game | Platform | Version | Mode |
--- | --- | --- | ---
| GTA 3 | PC, not for DE | ? | main.scm, CLEO 2.0.0.5 |
| GTA VC | PC, not for DE | ? | main.scm, CLEO 2.0.0.5 |
| GTA SA | PC, not for DE | 1.0 | main.scm, CLEO 4.4.0 |

## Advantages and disadvantages

To generate the code, you need basic C# skills and an understanding of how SCM scripts work in GTA. Some things are hard enough to implement or not as convenient as we would like. Therefore, I will demonstrate all the pros and cons of this generator in the table below:

| Advantages | Disadvantages |
--- | ---
| Automatic code generation for threads, missions, external scripts and SCM functions | Requirement for knowledge of a third-party programming language (C#) |
| Automatic generation of labels and script variables | The ability to use the existing functionality and the ability to expand it in favor of convenience |
| Using C# tools to increase development speed | There is a requirement to use a professional IDE (for example, Visual Studio) |
| Improved type checking to reduce logical errors in development | Some of the things Sanny Builder can do are impossible to implement, so they are missing |
| Smart generation will collect only those scripts that were called during the generation process, which helps in debugging by cutting off scripts or labels that are not needed at the moment | Some of the syntax can be confusing |
| Support for plugins written by experienced developers | Strong typing can make it difficult to override existing variables |
| Supports 3 games (GTA III, VC, SA), modes "MAIN" and "CLEO" | The typical behavior of labels in Sanny Builder works differently from in generator |
| Maximum matching of class names and functions to Sanny Builder | Supports only PC versions of games |

## Other

| Examples | Tutorials |
--- | ---
|  | ![ENG](https://wmysterio.gitbook.io/gtasg/) |
| ![Project Unknown (main.scm)](https://github.com/wmysterio/GTA-SA_Project-Unknown) | ![RUS](https://wmysterio.gitbook.io/gtasg/v/ru/) |
