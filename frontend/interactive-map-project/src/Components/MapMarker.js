import mapboxgl from 'mapbox-gl';

const MapMarker = ({ map, lngLat, popupText }) => {
    // Create a marker
    const marker = new mapboxgl.Marker().setLngLat(lngLat).addTo(map);

    // Create a popup
    const popup = new mapboxgl.Popup({ offset: 25 }).setHTML(popupText);

    // Add popup on marker hover
    marker.getElement().addEventListener('mouseenter', () => {
        marker.togglePopup(popup).addTo(map);
    });

    // Remove popup on marker hover out
    marker.getElement().addEventListener('mouseleave', () => {
        marker.togglePopup(popup);
    });

    return null;
};

export default MapMarker;

