console.log("hello");
const mock = [
    {
        title: "משחקי חשיבהה",
        text: 'שחק חשיבה הוא אחד האמצעים הטובים לפיתוח מיומנויות חשיבה בשילוב הנאה. המשחקים מהווים "תרגילי התעמלות למוח" ומפתחים מגוון מיומנויות חשיבה',
        img: 'https://images.unsplash.com/photo-1481349518771-20055b2a7b24?ixid=MnwxMjA3fDB8MHxzZWFyY2h8M3x8cmFuZG9tfGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80',
        category: 0
    },
    {
        title: "משחקי קופסא",
        text: "משחקי לוח, משחקי קלפים, משחקי קוביות, משחקי מלחמה ועוד.",
        img: 'http://www.mandysam.com/img/random.jpg',
        category: 1
    },
    {
        title: "משחקי ואביזרי ספורט",
        text: "אביזרי התעמלות, כדורים, ציוד התעמלות.",
        img: ' /Photos/ballgames.jpg',
        category: 2
    },
    {
        title: "משחקי מחשב וקונסולה",
        text: "משחקים חדישים, ציוד היקפי",
        img: ' /Photos/CmGames.jpg',
        category: 3
    },
    {
        title: "משחקי לגו",
        text: "ציוד לגו להרכבה ובנייה",
        img: ' /Photos/Lego_bricks.jpg',
        category: 4
    },
    {
        title: "משחקים כלשהם צריך לערוך",
        text: "משחקים חדישים, ציוד היקפי",
        img: ' /Photos/CmGames.jpg',
        category: 5
    }
]

function getCategories(data) {
    
    for (let i = 0; i < data.length; i++) {

        $(".categoriesContainer").append(
            '<div class= "card col-sm-4" > <img src=' + mock[i].img + ' class="card-img-top" alt="...">' +
            '<div class="card-body">' +
            '<h5 class="card-title">' + mock[i].title + '</h5>' +
            '<p class="card-text">' + mock[i].text + '</p>' +
            '<a href="#" class="btn btn-primary" onclick="goToCategoryItems(' + mock[i].category + ')" >View Category Items</a>' +
            '</div>' +
            '</div>'
        )

    };

}
getCategories(mock);

function goToCategoryItems(categoryId) {
    window.location.href = 'Home/Item?categoryId=' + categoryId;
}

//function appendToHtmlElement(className, element) {
    
//    $(`.${className}`).append(element);
//}