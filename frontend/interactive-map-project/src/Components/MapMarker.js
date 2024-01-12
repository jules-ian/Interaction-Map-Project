import mapboxgl from 'mapbox-gl';

const MapMarker = ({ map, lngLat, popupText }) => {
    // Create a marker
    const marker = new mapboxgl.Marker().setLngLat(lngLat);

    // Create a popup
    const popup = new mapboxgl.Popup({ offset: 25 }).setHTML(popupText);

    // Add popup on marker hover
    marker.addTo(map).setPopup(popup);

    // Show popup on marker mouseenter
    marker.getElement().addEventListener('mouseenter', () => {
        marker.togglePopup();
    });

    // Hide popup on marker mouseleave
    marker.getElement().addEventListener('mouseleave', () => {
        marker.togglePopup();
    });

    return null;
};

export default MapMarker;
