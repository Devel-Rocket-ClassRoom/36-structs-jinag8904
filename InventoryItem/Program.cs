using System;

Console.WriteLine("=== 인벤토리 목록 ===");

InventoryItem[] items =
{
    new InventoryItem("검", 3.5, 1500),
    new InventoryItem("방패", 5.0, 1200),
    new InventoryItem("포션", 0.3, 50),
    new InventoryItem("활", 1.8, 1300),
    new InventoryItem("투구", 2.0, 800)
};

double weightSum = 0;
int priceSum = 0;

int mostExpIndex = 0;
int mostLigthIndex = 0;

for (int i = 0;  i < items.Length; i++)
{
    items[i].ShowInfo();
    weightSum += items[i].Weight;
    priceSum += items[i].Price;

    if (items[mostExpIndex].Price < items[i].Price) mostExpIndex = i;
    if (items[mostLigthIndex].Weight > items[i].Weight) mostLigthIndex = i;
}

int priceAvg = priceSum / items.Length;

Console.WriteLine("\n=== 인벤토리 통계 ===");

Console.WriteLine($"전체 무게: {weightSum:f1}kg");
Console.WriteLine($"전체 가격: {priceSum}골드");
Console.WriteLine($"평균 가격: {priceAvg}골드");
Console.WriteLine($"가장 비싼 아이템: {items[mostExpIndex].Name}");
Console.WriteLine($"가장 가벼운 아이템: {items[mostLigthIndex].Name}");