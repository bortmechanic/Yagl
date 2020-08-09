# Introduction 
'YAGL' stands for 'Yet Another Graphics Library'. Check the Urban Dictionary for any other meanings.
YAGL is a library (or set of libraries) intended to simplify creating graphical applications and games with C# and
other .NET languages.

# Details
- Language: C# (.NetStandard 2.x)
- Platforms: Windows, Mac OS, Linux (various) (currently only in mind). Android, iOS a bit later.
- Technologies: .NET, OpenGL

# Principles
- Performance. The YAGL libraries should outperform closest competitors or at least performance should be the same.
- Simplicity. The YAGL libraries should be very simple and intuitive at list on the higher levels of architecture.
- Layered architecture. All the functionality should be divided into separate layers from most low level api calls to graphics 
driver to high level abstractions like model, scene and application. A user (developer) should be able to choose what level he/she 
is working
with.
- Modular architecture. All the functionality should be divided into logically separated modules. The modules should be represented 
as libraries or namespaces in the same library. A user should be able to choose which modules to use or not to use.
- Cross-platform. The YAGL libraries should be truly cross-platform. At lease Win/Mac/Linux/Android/iOS must be supported.
- Well documented. Every piece of functionality must be well documented. It means every class/method/parameter/field must have a 
description that is enough to completely understand the member function and may be some examples of use if needed.

# Status
The project is in early development stage (not alpha, not beta, nor any stable releases). So please don't expect anything great or 
stable. Any ideas, proposals, critics and compliments are welcome.

# License
If possible, all the libraries will be distributed under the MIT license. I want everything to be really free. So you may do 
everything with the code/binaries for free. Well.., almost everything. Please read the license first.
