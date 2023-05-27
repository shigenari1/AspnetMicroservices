# 商品APIの利用
---
## usecase
これは商品情報を管理するためのAPIです。以下の表は、それぞれのユースケースに対応するメソッドとURIを示しています。

| Method | URI                | ユースケース                                |
|--------|--------------------|-----------------------------------------|
| GET    | /api/v1/Catalog     | 製品の一覧を取得                         |
| GET    | /api/v1/Catalog/{id}| 特定の製品の詳細を取得                   |
| POST   | /api/v1/Catalog     | 新たな製品をカタログに追加              |
| PUT    | /api/v1/Catalog/{id}| 特定の製品情報の更新                   |
| DELETE | /api/v1/Catalog/{id}| 特定の製品をカタログから削除            |
| GET    | /api/v1/Catalog/search| キーワードによる製品検索             |
| GET    | /api/v1/Catalog/category/{category}| 特定のカテゴリの製品一覧を取得|
| POST   | /api/v1/Catalog/{id}/review | 特定の製品にレビューを追加      |
| GET    | /api/v1/Catalog/{id}/review | 特定の製品のレビュー一覧を取得|

これらのAPIにアクセスするためには適切な認証トークンが必要です。各APIとそのパラメータについての詳細は、詳細なAPIドキュメンテーションをご参照ください。

---

## Archictecture
-  N層Arcを採用
	- Data Access Layer
		- databaseの操作のみを実行します
	- Business Logic Layer
		- ビジネスロジックを実行します
	- Presentation Layer
		- ユーザとの対話を実行します

![arc](https://user-images.githubusercontent.com/16585369/241391670-70e574f9-4554-44a2-a4de-26a46227bb32.png)

- Repository Patternを採用
	- 目的
		- データ層の抽象化
		- ドメインオブジェクトの処理を一元化
	- 利点
		- データアクセスコードがアプリケーションから分離出来ることで変更が必要な箇所が1箇所でOK
		- コントローラのテストが容易になる

## Setting

### MongoDB
```
docker pull mongo
docker run -d -p 27017:27017 --name shopping-mongo
```