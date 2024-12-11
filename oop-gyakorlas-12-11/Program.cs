using oop_gyakorlas_12_11;

Penztarca p=new Penztarca(1);

Console.WriteLine(p.Penz);

p.szin = "Fekete";
Console.WriteLine(p.szin);

Penztarca p2= new Penztarca(20000,"Black Ice"); // Új pénztárca létrehozása

Console.WriteLine(p2.Penz); // P2-nek a pénzösszeg kiiratása


Console.WriteLine(p2); // P2 Kiiratás