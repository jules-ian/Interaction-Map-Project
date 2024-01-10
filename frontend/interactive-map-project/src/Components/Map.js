// Map.js
import React, { useEffect, useRef, useState } from "react";
import mapboxgl from "mapbox-gl";
import "mapbox-gl/dist/mapbox-gl.css";
import MapMarker from "./MapMarker";
import useWindowDimensions from "../utils/windowDimension";

mapboxgl.accessToken =
  "pk.eyJ1Ijoic29uZHJlbHV4IiwiYSI6ImNsbnZ3aXRneDAzcDcydG82NGE2dG4xYnQifQ._TpEa0XTz2SpM5Zv9xju_w";

const Map = ({ setMapBounds, results }) => {
  const mapContainerRef = useRef(null);
  const { height, width } = useWindowDimensions();

  useEffect(() => {
    const map = new mapboxgl.Map({
      container: mapContainerRef.current,
      style: "mapbox://styles/mapbox/streets-v11",
      center: [1.4442, 43.6047],
      zoom: 7,
    });

    const nav = new mapboxgl.NavigationControl({
      showZoom: true,
      showCompass: false,
    });

    map.addControl(nav, "bottom-right");

    // Set initial map bounds
    setMapBounds(map.getBounds());

    // Listen for map move events and update bounds
    map.on("move", () => {
      setMapBounds(map.getBounds());
    });

    // Add markers based on search results
    results.forEach((professional) => {
      const { geoLocation, name } = professional;
      if (geoLocation && geoLocation.coordinates) {
        const [lng, lat] = geoLocation.coordinates;
        MapMarker({ map, lngLat: [lng, lat], popupText: name });
      }
    });

    return () => map.remove();
  }, [setMapBounds, results]);

  return (
    <div
      ref={mapContainerRef}
      style={{ width: "100%", height: height * 0.8 }}
    />
  );
};

export default Map;
