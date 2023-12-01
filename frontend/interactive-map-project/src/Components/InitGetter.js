// InfoGetter.js
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Dropdown from './DropMultiSelect';

const InitGetter = (API) => {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios.get('API HELPPP')
      .then(response => {
        setData(response.data);
      })
      .catch(error => {
        console.error('Error fetching data:', error);
      });
  }, []);

  return data;
};

export default InitGetter;
