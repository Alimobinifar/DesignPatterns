# Design Patterns Playground 🚀

A **C#/.NET playground project** that demonstrates the most common **Design Patterns** in three categories:  
- **Creational**
- **Structural**
- **Behavioral**

The purpose of this repository is to provide **clean, minimal, and educational implementations** of design patterns.  
Each pattern is organized in its own folder and comes with a **demo class** so you can run and test it directly.

---

## 📂 Project Structure
DesignPatternsPlayground/
│
├── Behavioral/
│ └── Strategy/
│	├── IDiscountStrategy.cs
│   ├── RegularCustomerDiscount.cs
│	├── VipCustomerDiscount.cs
│   ├── SeasonalDiscount.cs
│	├── CouponCodeDiscount.cs
│	├── PriceCalculator.cs
│	└── StrategyDemo.cs
│
├── Creational/
│ └── ...
│
├── Structural/
│ └── ...
│
└── Program.cs


---

## ▶️ How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/AliMobinifar/DesignPatternsPlayground.git
2. Open in Visual Studio 2022 (or later).
3. Set DesignPatternsPlayground as the startup project.
4. Run the application.
You will see pattern demos in the console output.

🎯 Example: Strategy Pattern

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
It lets the algorithm vary independently from clients that use it.

In this example, we calculate product prices with different discount strategies:

RegularCustomerDiscount → no discount

VipCustomerDiscount → 20% off

SeasonalDiscount → configurable seasonal discount

CouponCodeDiscount → discount applied based on coupon code (e.g., OFF10, OFF25, OFF50)

**Demo Output:**

=== Strategy Pattern Demo ===
Regular Customer: 100
VIP Customer: 80
Festival Discount: 90
Coupon OFF25: 75

✅ Patterns Covered (so far)

Behavioral:

  ✅ Strategy

Creational:

 Factory Method

 Singleton

Structural:

 Adapter

 Decorator

 Facade

(Work in progress... more patterns will be added daily!)


🧪 Unit Tests:

Unit tests are written using xUnit to verify each strategy and pattern implementation.
Check the Tests/ folder for details.

📌 Goals:

Learn and practice GoF Design Patterns in C#

Provide production-ready, minimal examples

Build a portfolio-friendly GitHub repository

📜 License:

MIT License - free to use and share.