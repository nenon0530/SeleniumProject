# **Seleniumによるマルチブラウザテスト自動化DEMOメモ**
- **Seleniumとは**  
Selenium（セレニウム）はブラウザのオートメーションツールです。   
自動でブラウザを操作することでWebサイトの動作のテストを行うことができます。  

- **導入効果**  
下記２種類のSeleniumツールを組み合わせて、マルチブラウザ（Chrome,IE,EDGE）テストの効率化を図る  

| ツール            |用途                                                 | 対応ブラウザ |
|:------------------:|:---------------------------------------------------:|:------------:|
| Selenium IDE      |FireFoxアドオン。Web操作をマクロで記録できる。          | FireFox,Chrome,IE|
| Selenium WebDriver|Java、C#、Python、Rubyが使えるWebテスト自動化ライブラリ | FireFox,Chrome,IE,Edge|

- **手順概要**  
  ①FireFoxインストールして、Selenium IDEを導入  ※最新バージョンFireFoxは現在Selenium ID導入できない
  ②Selenium IDEのマクロ機能を使って、Web操作を記録して、テストコード(C#)を自動生成 
　③テストコード(C#)をVisual Studioのテストプロジェクトにコピーし、Selenium WebDriverを使ってマルチブラウザテストを実施
