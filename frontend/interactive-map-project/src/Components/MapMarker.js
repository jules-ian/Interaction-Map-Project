import mapboxgl from 'mapbox-gl';

const MapMarker = ({ map, lngLat, popupText }) => {
    const marker = new mapboxgl.Marker()
        .setLngLat(lngLat)
        .addTo(map);

    // Add a popup on marker click
    const popup = new mapboxgl.Popup().setLngLat(lngLat).setHTML(popupText);

    marker.getElement().addEventListener('click', () => {
        // Toggle the popup on click
        if (popup.isOpen()) {
            popup.remove();
        } else {
            marker.setPopup(popup).addTo(map);
        }
    });

    return null;
};

export default MapMarker;

