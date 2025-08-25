<div dir="rtl">
 فارسی

الگوی Strategy (استراتژی) یک الگوی رفتاری (Behavioral Pattern) است که به ما اجازه می‌دهد خانواده‌ای از الگوریتم‌ها را تعریف کنیم و در زمان اجرا یکی از آن‌ها را انتخاب کنیم، بدون اینکه کدی که از آن‌ها استفاده می‌کند تغییر کند.

کاربرد اصلی:
وقتی چندین روش مختلف برای انجام یک کار وجود دارد (مثلاً محاسبه مالیات، روش‌های پرداخت، یا الگوریتم‌های مرتب‌سازی)، به جای نوشتن if-elseهای طولانی، هر الگوریتم در یک کلاس جدا تعریف می‌شود و برنامه‌نویس می‌تواند به راحتی یکی از آن‌ها را جایگزین دیگری کند.

مزایا:

حذف شرط‌های تودرتو (if-else / switch)

کد تمیزتر و قابل نگهداری‌تر

امکان اضافه کردن استراتژی‌های جدید بدون تغییر در کد موجود (اصل Open/Closed)
</div>

English

The Strategy Pattern is a behavioral design pattern that enables you to define a family of algorithms, encapsulate each one, and make them interchangeable at runtime.

Main use case:
When multiple ways exist to perform a task (e.g., tax calculation, payment methods, sorting algorithms), instead of having long if-else or switch statements, each algorithm is placed in its own class. The client code then chooses the desired algorithm at runtime.

Advantages:

Removes long conditional statements

Cleaner and more maintainable code

Allows adding new strategies without modifying existing code (Open/Closed Principle)
