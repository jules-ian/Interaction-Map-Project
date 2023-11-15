import logo from './logo.svg';
import './App.css';
import DropMultiSelect from './Components/DropMultiSelect';
import SearchBar from './Components/SearchBar';
export default function App() {
  const testStyle = {
    padding:10
  }
  return (
    <div style={testStyle}>
      <SearchBar/> 
      <DropMultiSelect/> 
    </div>
)}
