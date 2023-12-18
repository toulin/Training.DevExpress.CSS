## 大要說明
本範程式是以C# Winform為主要開發工具，並以DevExpress的HtmlContent控件作為主要樣式設計，進行CSS樣式設計的示範程式。  
將樣式設計在自訂控件中，集中存放在UserControl目錄下

---
## 練習設計按鈕樣式與排版(MyButtonByCss)

示例學習目標
* 了解如何指定觸發按鍵事件 OnClick
* 了解 id class的作用 
* 如何設計"已按下"的效果 

 已按下效果：透過OnClick事件, 來變更上次的Element.ClassName設定值(上次按鈕恢復一般樣式)，以及變更按下的Element.ClassName設定值(按下鈕的樣式)；
 以此來達到"已按下"效果

---
 ## 練習設計浮動視窗樣式(MyPopupByCSS)
 示例學習目標
 * 如何設計浮動視窗樣式 - 使用 HtmlContent & HtmlContentPopup控件(並參考本示例中的建構式)
 * 如何顯示圖示 
 * 如何動態顯示文字

 ### 顯示圖示
 1. 從工具箱拉一個SvgImageCollection控制項，再新增想要的圖示及指定圖示的Name值
 2. 在HTML-Template中想要帶入的圖示的地方，加入如下例的標籤

    	<img src="ArrowDown">

 ### 動態顯示文字
 1. 為HtmlContent控件的DataContext帶入指定的實例(自訂的資料類別)，本示例的代碼如下

        SPModeHtmlContent.DataContext = settings; //settings為自訂的資料類別實例

 2. 在HTML-Template中想要動態顯示文字中，加入指定的屬性名稱，如下例

    	${DisplaySPMode}

---
## DevExpress DEMO
打開Demo程式，打開"Winforms"視窗選單，點選"HTML & CSS Templates"，可看到 CSS樣式設計的範例

在左側的 CSS 有各種樣式設計的範例，點選後，右側會顯示該樣式的效果，並且可以看到該樣式的CSS設定值