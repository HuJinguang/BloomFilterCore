# Bloom Filter Core
[![Build status](https://ci.appveyor.com/api/projects/status/3mo51j2ssn4l0l52?svg=true)](https://ci.appveyor.com/project/giometrix/bloomfiltercore) 
[![](https://img.shields.io/nuget/v/BloomFilterCore.svg)](https://www.nuget.org/packages/BloomFilterCore/)


This library was decompiled from an MIT licensed library obtained from [Nuget](https://www.nuget.org/packages/BloomFilter/) and recompiled for .NET Standard.  All credit goes to Graham Henry who is the original creator.  Unfortunately I could not find the code online.

### Description (copied from Nuget description)
A Bloom Filter is a probabalistic data structure that Implements the Add() and Contains() methods in a memory efficient manner when compared to the more traditional Hash Set. However, the Bloom Filter has some draw backs:

* It will sometimes indicate that an element is in the set when it isn't. The False Positive rate can be decreased by using more memory.

* The capacity of the Bloom Filter is fixed at creation time. (You can add more elements than the target capacity, but the False Positive rate continues to increase thereafter).
