import React from 'react';
import ProductList from './ProductList';
import "../node_modules/bootstrap/dist/css/bootstrap.min.css";

function App() {
  return (
    <div className="App">
      <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
        <div className="container">
          <a className="navbar-brand" href="/">
            My Store
          </a>
        </div>
      </nav>
      <ProductList />
    </div>
  );
}

export default App;
