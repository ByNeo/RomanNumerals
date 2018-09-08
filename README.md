# RomanNumerals
Converting a Roman numeral.

<br>

To Run
------
<br>

To configure multiple runs of API and Web projects:
___________________________________________________
**Visual Studio -> Solution Explorer -> Solution (Right Click) -> Properties -> Startup Projects -> Multiple startup projects (Radio Click)**

RomanNumerals.API => Start
<br>
RomanNumerals.Core => None
<br>
RomanNumerals.Tests => None
<br>
RomanNumerals.Web => Start
____________________________________________________

**WARNING:** The port that **RomanNumerals.API** runs should be **"30667"**. **URL: http://localhost:30667/**
<br>
If the API's port has changed:
**"RomanNumerals.Web -> Scripts -> pageViewJS -> romanNumerals.js"** in change the port number on **line 2.
