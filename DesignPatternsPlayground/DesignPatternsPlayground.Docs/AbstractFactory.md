<div dir="rtl">

الگوی طراحی Abstract Factory یکی از الگوهای ساختاری (Creational Patterns) است که به ما امکان می‌دهد خانواده‌ای از اشیاء مرتبط یا وابسته را بدون مشخص کردن کلاس‌های دقیق آن‌ها ایجاد کنیم.
در این الگو، یک اینترفیس یا کلاس انتزاعی برای ساخت اشیاء تعریف می‌شود و هر کارخانه‌ی مشخص (Concrete Factory) این اینترفیس را پیاده‌سازی می‌کند تا محصولات خاص خودش را بسازد.
این الگو باعث جداسازی ساخت اشیاء از استفاده‌ی آن‌ها می‌شود و کد را قابل توسعه، انعطاف‌پذیر و قابل نگهداری می‌کند.

کاربرد اصلی:
زمانی که برنامه نیاز دارد چند خانواده از اشیاء مرتبط داشته باشد که باید به صورت هماهنگ با هم استفاده شوند، مثلا ساخت انواع مختلف وسایل نقلیه برقی یا بنزینی.

مزایا:

جداسازی کامل کد از جزئیات پیاده‌سازی

امکان افزودن خانواده‌های جدید بدون تغییر کد کلاینت

حفظ سازگاری بین محصولات خانواده‌ها

مثال:
در پروژه‌ای که انواع مختلف ماشین و موتور (برقی یا بنزینی) وجود دارد، هر کارخانه (برقی یا بنزینی) مسئول ساخت اشیاء خودش است و برنامه‌ی اصلی فقط با اینترفیس‌ها کار می‌کند.
</div>

English Explanation

The Abstract Factory design pattern is a creational pattern that allows the creation of families of related or dependent objects without specifying their concrete classes.
In this pattern, an interface or abstract class defines methods for creating abstract products, and each concrete factory implements this interface to create specific products.
This separates the creation of objects from their usage, making the code more flexible, extensible, and maintainable.

Main Use Case:
When a system needs to work with multiple families of related products that should be used together, such as electric or gas-powered vehicles.

Benefits:

Complete decoupling of client code from implementation details

Ability to add new product families without changing client code

Ensures compatibility among products within a family

Example:
In a project with different types of cars and motorbikes (electric or gas), each factory (electric or gas) creates its respective products, and the main program works only with interfaces.