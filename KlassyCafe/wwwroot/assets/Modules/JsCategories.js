let CatsArr = [];
//cat for categories 
let JsCategories = {
    LoadCategories: function () {
        Helper.AjaxCallGet("/api/CategoriesApi", {}, "Json", function (data) {

            let HtmlCategories = "";
            console.log(data);
            ItemArr = data;

           /* alert("Cats");*/
            //We can make if condetion if i%2 ==0 store in variable else store in the second 
           

            for (i = 0; i < data.length; i++) {

                HtmlCategories = HtmlCategories + JsCategories.Categorize(data[i])

            }

            $("#Categories").html(HtmlCategories);

            console.log(HtmlCategories);
        },
            function () {

            });
    },
    // 
    Categorize: function (Cat) {

        let HtmlData = "<li><a onclick='JsItems.filterData2(" + Cat.categoryId + ")' ><img src='assets/images/tab-icon-01.png' alt=''>" + Cat.categoryName + "</a></li>";

        return HtmlData;
    }
};
JsCategories.LoadCategories();
