# Traffic lights C# Async lesson
I saw many lessons for beginners, how to use asyncronous functions.
Subjective, it will the easiest way to understand await-word mind. 

The asyncronous functions defines like this:
```csharp
private Task DefineSmth(object[] parameters)
```
Just because, this fumctions must be called in new threads. For running Async-Functions you can use ```async``` and ```await``` words. 
example:
```csharp
private async Task RunToDoList()
{
  await DefineSmth(new object[] { "arg1", "arg2" });
  await DestroyUnusedObject(unusedObject);
  await Something();
}
```
For run async-word function, you can use ```Task```-class too.

Try to do same Application by self.
