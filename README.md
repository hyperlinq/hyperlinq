hyperlinq
=========

FAQ: https://github.com/hyperlinq/hyperlinq/wiki/FAQ 

Blog: http://hyperlinq.blogspot.co.uk/

Hyperlinq on Nuget:
https://www.nuget.org/packages/Hyperlinq

If you want to compile the actual Hyperlinq project (rather than just use the .dll), you'll probably want to get rid of the T4 template, and just use the file the T4 template generates. The T4 template relies on the HyperlinqCodeGenSource project to auto-generate all the HTML element and attribute helpers.
