import React, { useEffect } from 'react';
import mapboxgl from 'mapbox-gl';
import 'mapbox-gl/dist/mapbox-gl.css';

// Set your Mapbox access token
mapboxgl.accessToken = "pk.eyJ1Ijoic29uZHJlbHV4IiwiYSI6ImNsbnZ3aXRneDAzcDcydG82NGE2dG4xYnQifQ._TpEa0XTz2SpM5Zv9xju_w";

const Map = () => {
  useEffect(() => {
    // Create a new map instance
    const map = new mapboxgl.Map({
      container: 'map-container', // container ID
      style: 'mapbox://styles/mapbox/streets-v11', // style URL
      center: [1.4442, 43.6047], // Toulouse coordinates [lng, lat]
      zoom: 12 // Zoom level
    });


    const marker = new mapboxgl.Marker()
      .setLngLat([1.4442, 43.6047]) // Toulouse coordinates [lng, lat]
      .addTo(map);

    // Add hover interactions
    marker.getElement().addEventListener('mouseenter', () => {
      // Increase marker size on hover
      marker.getElement().style.transform = 'scale(1.5)';
      
      // Add a popup with text
      new mapboxgl.Popup()
        .setLngLat([1.4442, 43.6047]) // Toulouse coordinates [lng, lat]
        .setHTML('DOCTOR 1')
        .addTo(map);
    });

    marker.getElement().addEventListener('mouseleave', () => {
      // Reset marker size on mouse leave
      marker.getElement().style.transform = 'scale(1)';
      
      // Remove the popup on mouse leave
      document.querySelectorAll('.mapboxgl-popup').forEach(popup => popup.remove());
    });

    // Cleanup on component unmount
    return () => map.remove();
  }, []); // empty dependency array ensures this effect runs once on component mount


  return (
    <div id="map-container" style={{ width: '100%', height: '400px' }} />
  );
};

export default Map;





