
var map;
function initialize() {
    map = new google.maps.Map(document.getElementById('map-canvas'), {
        zoom: 14,
        center: new google.maps.LatLng(53.702976, -111.987119),
        mapTypeId: google.maps.MapTypeId.SATELLITE
    });
}

google.maps.event.addDomListener(window, 'load', initialize);



function initialize1() {

    // build the map's center point
    centerpoint = new google.maps.LatLng(53.702976, -111.987119);

    var mapOptions = {
        center: centerpoint,
        zoom: 12,
        mapTypeId: google.maps.MapTypeId.SATELLITE
    };

    map = new google.maps.Map(
        document.getElementById('map-canvas'),
        mapOptions
    );

    // create a dialog box but don't bind it to anything yet
    myInfoWindow = new google.maps.InfoWindow();
    // show drawing tools
    DrawingTools();

    //var fields = [];
    //var polygons = [];

    //var fieldCoordinates = [
    //    new google.maps.LatLng(53.686806, -111.992676),
    //    new google.maps.LatLng(53.686806, -112.004650),
    //    new google.maps.LatLng(53.679765, -112.004564),
    //    new google.maps.LatLng(53.679689, -111.992891)
    //];

    //var fieldCoordinates2 = [
    //    new google.maps.LatLng(53.708529, -112.004564),
    //    new google.maps.LatLng(53.708682, -111.992805),
    //    new google.maps.LatLng(53.701747, -111.992848),
    //    new google.maps.LatLng(53.701670, -112.004607)
    //];

    ////alert(fieldCoordinates2[0].toString());

    //fields.push(fieldCoordinates);
    //fields.push(fieldCoordinates2);

    //for (var i = 0; i < fields.length; i++)
    //{

    //    polygons.push(new google.maps.Polygon({
    //        paths: fields[i],
    //        id: 1 + i,
    //        strokeColor: '#FF0000',
    //        strokeOpacity: 0.8,
    //        strokeWeight: 3,
    //        fillColor: '#D2F18B',
    //        fillOpacity: 0.35
    //    }));



    //    google.maps.event.addListener(polygons[i], 'click', function () {

    //        var polygonPaths = this.getPath();

    //        var test2 = polygonPaths.getArray().toString();

    //        var backToArray = test2.match(/([^,]+,[^,]+)/g);

    //        var pointArray = [];

    //        for (var i = 0; i < backToArray.length; i++) {

    //            var temp = getCoordinatesFromString(backToArray[i]);

    //            pointArray.push(new google.maps.LatLng(temp[0], temp[1]));
    //        }

    //        polygons.push(new google.maps.Polygon({
    //            paths: pointArray,
    //            id: 100,
    //            strokeColor: '#FF0000',
    //            strokeOpacity: 0.8,
    //            strokeWeight: 3,
    //            fillColor: '#D2F18B',
    //            fillOpacity: 0.35
    //        }));

    //        alert("Here");

    //        this.setMap(this.map);

    //    });





    //}



    //for (var a = 0 ; a < polygons.length ; a++)
    //{
    //    polygons[a].setMap(map);
    //}


}

/**
* Show drawing tools
*/
function DrawingTools() {

    // drawingMode of NULL, which means that the map drawing tools will
    // have no default drawing tool selected. If drawingMode was set to
    // google.maps.drawing.OverlayType.POLYGON, polygon would be auto-
    // selected
    // drawingModes can have multiple information. Over here only the
    // polygon capability is added along with the default of hand icon
    // Moreover, polygonOptions are specified as defaults
    myDrawingManager = new google.maps.drawing.DrawingManager({
        drawingMode: null,
        drawingControl: true,
        drawingControlOptions: {
            position: google.maps.ControlPosition.TOP_RIGHT,
            drawingModes: [
                google.maps.drawing.OverlayType.POLYGON
            ]
        },
        polygonOptions: {
            draggable: false,
            editable: true,
            fillColor: '#cccccc',
            fillOpacity: 0.5,
            strokeColor: '#000000'
        }
    });
    myDrawingManager.setMap(map);

    // when polygon drawing is complete, an event is raised by the map
    // this function will listen to the event and work appropriately
    FieldDrawingCompletionListener();
}

/**
* Using the drawing tools, when a polygon is drawn an event is raised.
* This function catches that event and hides the drawing tool. It also
* makes the polygon non-draggable and non-editable. It adds custom
* properties to the polygon and generates a listener to listen to click
* events on the created polygon
*/
function FieldDrawingCompletionListener() {
    // capture the field, set selector back to hand, remove drawing
    google.maps.event.addListener(
        myDrawingManager,
        'polygoncomplete',
        function (polygon) {
            myField = polygon;
            ShowDrawingTools(false);
            PolygonEditable(false);
            AddPropertyToField();
            FieldClickListener();
            //myFields.push(myfield);
            ShowDrawingTools(true);
        }
    );
}

/**
* Show or hide drawing tools
*/
function ShowDrawingTools(val) {
    myDrawingManager.setOptions({
        drawingMode: null,
        drawingControl: val
    });
}

/**
* Allow or disallow polygon to be editable
*/
function PolygonEditable(val) {
    myField.setOptions({
        editable: val
    });
    myInfoWindow.close();
    return false;
}

/**
* Add custom property to the polygon
*/
function AddPropertyToField() {
    var obj = {
        'id': 5,
        'grower': 'Joe',
        'farm': 'Dream Farm'
    };
    myField.objInfo = obj;
}

/**
* Attach an event listener to the polygon. When a user clicks on the
* polygon, get a formatted message that contains links to re-edit the
* polygon, mark the polygon as complete, or delete the polygon. The message
* appears as a dialog box
*/
function FieldClickListener() {
    google.maps.event.addListener(
        myField,
        'click',
        function (event) {
            var message = GetMessage(myField);
            myInfoWindow.setOptions({ content: message });
            myInfoWindow.setPosition(myField.center);
            myInfoWindow.open(map);
        }
    );
}

/**
* Delete the polygon and show the drawing tools so that new polygon can be
* created
*/
function DeleteField() {
    myInfoWindow.close();
    myField.setMap(null);
    ShowDrawingTools(true);
}

/**
* Get area of the drawn polygon in acres
*/
function GetArea(poly) {
    var result = parseFloat(google.maps.geometry.spherical.computeArea(poly.getPath())) * 0.000247105;
    return result.toFixed(4);
}

/**
* Get coordinates of the polygon and display information that should
* appear in the polygon's dialog box when it is clicked
*/
function GetMessage(polygon) {
    var message = '';

    if (typeof myField != 'undefined') {
        message += '<h1 style="color:#000">Grower: '
            + myField.objInfo.grower + '<br>'
            + 'Farm: ' + myField.objInfo.farm + '</h1>';
    }

    message += '<div style="color:#000">'
        + 'Area is ' + GetArea(polygon) + ' acres</div>';

    message += '<p><a href="#" onclick="PolygonEditable(true);">Edit</a> '
        + '<a href="#" onclick="PolygonEditable(false);">Done</a> '
        + '<a href="#" onclick="DeleteField(myField)">Delete</a></p>'

    return message;
}

function getCoordinatesFromString(stringToParse) {

    var temp = stringToParse.substring(1, stringToParse.length - 1);

    var tempArray = temp.split(",");

    var newArray = [];

    for (var i = 0; i < tempArray.length; i++) {
        newArray.push(parseFloat(tempArray[i]));
    }

    return newArray;

}

function showMessage() {
    alert("This thing worked!");
}

function fillFieldInfo() {

}

google.maps.event.addDomListener(window, 'load', initialize);
