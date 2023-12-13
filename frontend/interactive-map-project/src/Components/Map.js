// Map.js
import React, { useEffect, useRef } from 'react';
import mapboxgl from 'mapbox-gl';
import 'mapbox-gl/dist/mapbox-gl.css';
import MapMarker from './MapMarker';

mapboxgl.accessToken = "pk.eyJ1Ijoic29uZHJlbHV4IiwiYSI6ImNsbnZ3aXRneDAzcDcydG82NGE2dG4xYnQifQ._TpEa0XTz2SpM5Zv9xju_w";

const Map = () => {
  const mapContainerRef = useRef(null);

  useEffect(() => {
    const map = new mapboxgl.Map({
      container: mapContainerRef.current,
      style: 'mapbox://styles/mapbox/streets-v11',
      center: [1.4442, 43.6047],
      zoom: 12
    });

    // Add markers after the map is initialized
    MapMarker({ map, lngLat: [1.4442, 43.6047], popupText: "DOCTOR 1" });
    MapMarker({ map, lngLat: [1.455, 43.609], popupText: "DOCTOR 2" });

    return () => map.remove();
  }, []);

  return (
    <div ref={mapContainerRef} style={{ width: '100%', height: '400px' }} />
  );
};

export default Map;
