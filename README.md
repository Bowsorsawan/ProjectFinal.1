## ร้านขายของ
### ความเป็นมาของโปรแกรม
ที่ทำเพราะว่าซื้อขายอยู่ในชีวิตประจำวัน 
<br/><br/>
### วัตถุประสงค์ของโปรแกรม
พัฒนาขึ้นมาเพื่อใช้ในการศึกษาและเรียนรู้ในการเขียนโปรแกรมและเพื่อการพัฒนาในอนาคต


<br/><br/>
### โครงสร้างของโปรแกรม
```mermaid
classDiagram
    Program <|-- Form1
    Form1 <|-- Payment
    Form1 <|-- Receipt
    Program : +Main()
    class Form1{
        +btnAdd_Click()
        +addRow(string text1, string text2, string text3, string text4)
        +addRow(string text1, string text2, string text3, string text4, string text5)
        +btnRemove_Click()
        +openToolStripMenuItem_Click()
        +loadProductFromFile(string Npath)
        +btnPrint_Click()
    }
    class Payment{
        +button1_Click()
    }
    class Receipt{
        +Id(get; set;)
        +ProductName ( get; set; )
        +txtPrice ( get; set; )
        +Quantity ( get; set; )
    }
```
<br/><br/>
### ผู้พัฒนาโปรแกรม
ศรสวรรค์ ไพรอนันต์ 643450085-8
