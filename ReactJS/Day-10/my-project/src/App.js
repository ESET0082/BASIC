// import logo from './logo.svg';
// import './App.css';
import {BrowserRouter,Route,Routes} from "react-router-dom"
import HomePage from './Pages/HomePage';
import NavBar from './Components/NavBar';
import AboutPage from "./Pages/AboutPage";
import ApiPage from "./Pages/ApiPage";
function App() {
  return (
    <>
    <BrowserRouter>
    <NavBar/>
      <Routes>
        <Route path="/" element={<HomePage/>}></Route>
        <Route path="/about" element={<AboutPage/>}></Route>
        <Route path="/api" element={<ApiPage/>}></Route>
      </Routes>
    </BrowserRouter>
    
     {/* <HomePage/>  */}
    </>
  );
}

export default App;
