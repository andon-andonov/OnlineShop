import { useEffect, useState } from 'react';
import ProductListItem from './ProductListItem';
import { getProducts } from './ProductsApi';

const ProductList = () => {
  const [products, setProducts] = useState([]);
  const [loaded, setLoaded] = useState(false);

  useEffect(() => {
    getProducts().then((products) => {
      setProducts(products);
      setLoaded(true);
    });
  }, []);

  const productList = products.map((product) => (
    <ProductListItem key={product.id} product={product}></ProductListItem>
  ));

  return loaded ? (
    products?.length > 0 ? (
      productList
    ) : (
      <div>No products</div>
    )
  ) : (
    <div>Loading</div>
  );
};

export default ProductList;
