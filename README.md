<h1><b>Kata Poker Game with Two Players (Black and White)</b></h1>

<div style="font-size: 16px; color: rgb(33, 33, 33); font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;">
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;">&nbsp;</span></font></div>
</div>
<div style="font-size: 16px; color: rgb(33, 33, 33); font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;">
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif" color="black"><span style="font-size: 13.5pt;">A poker deck contains 52 cards - each card has a suit which is one of
 clubs, diamonds, hearts, or spades (denoted C, D, H, S in the input data). Each card also has a value which is one of 2, 3, 4, 5, 6, 7, 8, 9, 10, jack, queen, king, ace (denoted 2, 3, 4, 5, 6, 7, 8, 9, T, J, Q, K, A). For scoring purposes, the suits are unordered
 while the values are ordered as given above, with 2 being the lowest and ace the highest value.</span></font></span></font></div>
<div style="margin-top: 0px; margin-bottom: 0px;"><font size="4" face="Times New Roman,serif" color="black"><span style="font-size: 13.5pt;">A poker hand consists of 5 cards dealt from the deck. Poker hands are ranked by the following partial order from lowest
 to highest</span></font></div>
<ul style="margin-top: 14pt; margin-bottom: 0px;">
<li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">High Card. Hands which do not fit any higher category are ranked by the
 value of their highest card. If the highest cards have the same value, the hands are ranked by the next highest, and so on.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Pair. 2 of the 5 cards in the hand have the same value. Hands which both
 contain a pair are ranked by the value of the cards forming the pair. If these values are the same, the hands are ranked by the values of the cards not forming the pair, in decreasing order.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Two Pairs. The hand contains 2 different pairs. Hands which both contain
 2 pairs are ranked by the value of their highest pair. Hands with the same highest pair are ranked by the value of their other pair. If these values are the same the hands are ranked by the value of the remaining card.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Three of a Kind. Three of the cards in the hand have the same value.
 Hands which both contain three of a kind are ranked by the value of the 3 cards.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Straight. Hand contains 5 cards with consecutive values. Hands which
 both contain a straight are ranked by their highest card.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Flush. Hand contains 5 cards of the same suit. Hands which are both flushes
 are ranked using the rules for High Card.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Full House. 3 cards of the same value, with the remaining 2 cards forming
 a pair. Ranked by the value of the 3 cards.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Four of a kind. 4 cards with the same value. Ranked by the value of the
 4 cards.</span></font></span></font></li><li style="margin: 0px;"><font size="2" face="Calibri,sans-serif" color="black"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif"><span style="font-size: 13.5pt;">Straight flush. 5 cards of the same suit with consecutive values. Ranked
 by the highest card in the hand.</span></font></span></font></li></ul>
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif" color="black"><span style="font-size: 13.5pt;">Your job is to compare several pairs of poker hands and to indicate
 which, if either, has a higher rank.</span></font></span></font></div>
<div style="margin: 14pt 0px;"><font size="4" face="Calibri,sans-serif"><span style="font-size: 13.5pt;"><b><font face="Times New Roman,serif" color="black">The Input</font></b></span></font></div>
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif" color="black"><span style="font-size: 13.5pt;">Several lines, each containing the designation of 10 cards: the first
 5 cards are the hand for the player named "Black" and the next 5 cards are the hand for the player named "White."</span></font></span></font></div>
<div style="margin: 14pt 0px;"><font size="4" face="Calibri,sans-serif"><span style="font-size: 13.5pt;"><b><font face="Times New Roman,serif" color="black">The Output</font></b></span></font></div>
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;"><font size="4" face="Times New Roman,serif" color="black"><span style="font-size: 13.5pt;">For each line of input, print a line containing one of:</span></font></span></font></div>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">&nbsp;&nbsp; </font><font color="black">Black wins.</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">&nbsp;&nbsp; </font><font color="black">White wins.</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">&nbsp;&nbsp; </font><font color="black">Tie.</font></span></font></pre>
<div style="margin: 14pt 0px;"><font size="4" face="Calibri,sans-serif"><span style="font-size: 13.5pt;"><b><font face="Times New Roman,serif" color="black">Sample Input</font></b></span></font></div>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">2H 3D 5S 9C KD 2C 3H 4S 8C AH</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">2H 4S 4C 2D 4H 2S 8S AS QS 3S</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">2H 3D 5S 9C KD 2C 3H 4S 8C KH</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">2H 3D 5S 9C KD 2D 3H 5C 9S KH</font></span></font></pre>
<div style="margin: 14pt 0px;"><font size="4" face="Calibri,sans-serif"><span style="font-size: 13.5pt;"><b><font face="Times New Roman,serif" color="black">Sample Output</font></b></span></font></div>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">White wins.</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">Black wins.</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">Black wins.</font></span></font></pre>
<pre style="margin-top: 0px; margin-bottom: 0px;"><font size="2" face="Courier New"><span style="font-size: 10pt;"><font color="black">Tie.</font></span></font></pre>
</div>
<div style="font-size: 16px; color: rgb(33, 33, 33); font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;">
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;">&nbsp;</span></font></div>
</div>
<div style="font-size: 16px; color: rgb(33, 33, 33); font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;">
<div style="margin: 0px;"><font size="2" face="Calibri,sans-serif"><span style="font-size: 11pt;">&nbsp;</span></font></div>
</div>
<div style="font-size: 16px; color: rgb(33, 33, 33); font-family: wf_segoe-ui_normal, &quot;Segoe UI&quot;, &quot;Segoe WP&quot;, Tahoma, Arial, sans-serif, serif, EmojiFont;">
