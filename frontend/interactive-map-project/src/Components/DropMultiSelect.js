import Multiselect from 'multiselect-react-dropdown';
import { useState } from 'react';


function DropMultiSelect(){
    const [options,setOptions] = 
    useState([{name: 'Test 1', id: 1},{name: 'Option 2', id: 2},{name:"Alber3",id:3}])
    const [selected,setSelected]=
    useState([])
    
    function onSelect(selectedList, selectedItem) {

    }

    function onRemove(selectedList, removedItem) {
        
    }

    return(
        <Multiselect
        options={options} // Options to display in the dropdown
        selectedValues={selected} // Preselected value to persist in dropdown
        onSelect={onSelect} // Function will trigger on select event
        onRemove={onRemove} // Function will trigger on remove event
        displayValue="name" // Property name to display in the dropdown options
        />
    );
}

export default DropMultiSelect;
