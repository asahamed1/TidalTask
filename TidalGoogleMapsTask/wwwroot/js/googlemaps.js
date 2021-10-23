let map;
// Cario lat and lng 
const centerPostion = { lat: 30.033333, lng: 31.233334 }
let userCurrentLocation = centerPostion;

function initMap() {
    map = new google.maps.Map(document.getElementById("map"), {
        center: centerPostion,
        zoom: 8,
    });

    const marker = new google.maps.Marker({
        position: centerPostion,
        map: map,
    });
    
    // Create the initial InfoWindow.
    let infoWindow = new google.maps.InfoWindow({
        content: "Click the map to get Lat/Lng!",
        position: centerPostion,
    });

    infoWindow.open(map);
    // Configure the click listener.
    map.addListener("click", (mapsMouseEvent) => {
        // Close the current InfoWindow.
        infoWindow.close();
        // Create a new InfoWindow.
        infoWindow = new google.maps.InfoWindow({
            position: mapsMouseEvent.latLng,
        });
        infoWindow.setContent(
            JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2)
        );
        userCurrentLocation = mapsMouseEvent.latLng.toJSON();
        console.log(JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2))
        infoWindow.open(map);
    
    });
}
function SaveUserLoaction() {
    let errorLocationMsg =  document.getElementById("errorLocationMsg")
    if (userCurrentLocation == undefined) {
        errorLocationMsg.innerText = "Please Select your Location";
    } else {
        errorLocationMsg.innerText = "";

        $.ajax({

            url: 'Home/SaveUserLocation',
            type: 'POST',
            data: userCurrentLocation,
            dataType: 'json',
            success: function (data) {

                alert(data.message);
            },
            error: function (error) {
                alert(error.message);
            }
        });
    }
}