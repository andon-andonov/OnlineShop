import { useEffect, useState } from 'react';
import ProductListItem from './ProductListItem';

const GET_PRODUCTS_API_URL = 'http://localhost:5000/Products'; // TODO: move to env var

const ProductList = () => {
  const [products, setProducts] = useState([]);

  const getProducts = async () => {
    const response = await fetch(GET_PRODUCTS_API_URL);
    const data = await response.json();
    return data;
  };

  useEffect(() => {
    getProducts().then((products) => setProducts(products));
  }, []);

  return products?.length > 0 ? (
    products.map((product) => (
      <ProductListItem key={product.id} product={product}></ProductListItem>
    ))
  ) : (
    <div>empty</div>
  );
};

export default ProductList;
