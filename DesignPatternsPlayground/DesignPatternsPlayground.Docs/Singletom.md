# Singleton Pattern

---

<div dir="rtl">

## توضیح فارسی

الگوی **Singleton** یکی از پرکاربردترین الگوهای طراحی است.  
هدف اصلی این الگو این است که **فقط یک نمونه (Instance)** از یک کلاس در کل برنامه وجود داشته باشد و همه بخش‌ها از همان نمونه استفاده کنند.  

### چرا Singleton مهم است؟
- کنترل دسترسی به منابع مشترک (مثل Logger یا Database Connection).  
- جلوگیری از ساخت چندین شیء غیرضروری.  
- ساده‌سازی مدیریت وضعیت (State).  

### مثال (Logger)

```csharp
public class Logger
{
    private static readonly Logger _instance = new Logger();

    private Logger() { }

    public static Logger Instance => _instance;

    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}
استفاده :

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Hello, Singleton!");
        Logger.Instance.Log("Only one instance is used.");
    }
}


<div>

English Explanation

The Singleton pattern ensures that a class has only one instance and provides a global access point to it.

Why Singleton?

To manage shared resources (e.g., Logger, Database Connection).

Prevents unnecessary object creation.

Helps centralize state management.

public class Logger
{
    private static readonly Logger _instance = new Logger();

    private Logger() { }

    public static Logger Instance => _instance;

    public void Log(string message)
    {
        Console.WriteLine($"[Log] {message}");
    }
}

Usage :

class Program
{
    static void Main()
    {
        Logger.Instance.Log("Hello, Singleton!");
        Logger.Instance.Log("Only one instance is used.");
    }
}

