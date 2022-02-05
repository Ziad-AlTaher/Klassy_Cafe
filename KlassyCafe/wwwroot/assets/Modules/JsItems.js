let ItemArr = [];
let JsItems = {
    LoadItems: function () {
        Helper.AjaxCallGet("/api/ItmesApi", {}, "Json", function (data) {
            ItemArr = data;
            
            //We can make if condetion if i%2 ==0 store in variable else store in the second 
            let MnueDataLeft = "";
            let MnueDataright = "";

            for (i = 0; i < data.length; i++) {
                if (i != 0 && i % 2 == 0) {
                    MnueDataLeft = MnueDataLeft + JsItems.Menue(data[i])
                }
                else {
                    MnueDataright = MnueDataright + JsItems.Menue(data[i])
                }
                
            }


            $("#LMenue").html(MnueDataLeft);
            $("#RMenue").html(MnueDataright);
            //$("#LLMenue").html(MnueDataright);
            //$("#RRMenue").html(MnueDataLeft);
            
        },
            function () {

            });
    },


    Menue: function (item) {
         
       let HtmlData = "<div class='col-lg-12'>";
        HtmlData += "<div class='tab-item'>";
        HtmlData += "<img style='float:left; width:100px; max-width:100px; margin-right:20px; border-radius:5px;' src='/Uploads/" + item.imageName + "' alt='Image Not Found'>";
        HtmlData += "<h4>" + item.itemName + " </h4>";
        HtmlData += "<p>" + item.disciption + "</p>";
        HtmlData += "<div class='price'><h6> " + item.salesPrice + "$</h6 > </div> </div> </div>"
        return HtmlData;
    },

    FilteringData: function (CatId) {
        //function Called (Onclick Action in category button )
        //Filtering data function
        var returnedData = $.grep(ItemArr, function (element,i) {
            console.log("fun");
            console.log(element);
            return ItemArr.categoryId === CatId;
        }, false);

        //get reselt from filtering and drawing it 
        let MnueDataLeftt = "";
        let MnueDatarightt = "";
        
        for (i = 0; i < returnedData.length; i++) {
            //if to distrepute items in 2 dives
            if (i != 0 && i % 2 == 0) {
                MnueDataLeftt = MnueDataLeftt + JsItems.Menue(returnedData[i])
            }
            else {
                MnueDatarightt = MnueDatarightt + JsItems.Menue(returnedData[i])
            }
            console.log(MnueDataLeftt); console.log(MnueDatarightt);
            alert(i);
        }
       
        $("#LMenue").html(MnueDataLeftt);
        $("#RMenue").html(MnueDatarightt);
        //$("#LLMenue").html(MnueDatarightt);
        //$("#RRMenue").html(MnueDataLeftt);
    },

    filterData2: function (CatId) {
        //filtering like entity framework
        var returnedData = $.grep(ItemArr, function (element, i) {
     
            return element.categoryId === CatId;
        }, false);

        let MnueDataLeft = "";
        let MnueDataright = ""; 

        for (i = 0; i < returnedData.length; i++) {
            if (i != 0 && i % 2 == 0) {
                MnueDataLeft = MnueDataLeft + JsItems.Menue(returnedData[i])
            }
            else {
                if (i === 0) {
                    MnueDataLeft = MnueDataLeft + JsItems.Menue(returnedData[i])
                }
                else { MnueDataright = MnueDataright + JsItems.Menue(returnedData[i]) }
                
            }
        }

        $("#LMenue").html(MnueDataLeft);
        $("#RMenue").html(MnueDataright);
    }
};

JsItems.LoadItems();

