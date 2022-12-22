using System;
using The_shortest_word;

Checks checks=new Checks();
var maxNumberLetters= checks.MaxLong("  ");
var minNumberLetters = checks.MinLong("  ");
Console.WriteLine(maxNumberLetters);
Console.WriteLine(minNumberLetters);