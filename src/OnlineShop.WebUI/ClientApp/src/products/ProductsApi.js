const GET_PRODUCTS_API_URL = 'http://localhost:5000/Products'; // TODO: move to env var

const getProducts = async () => {
  const response = await fetch(GET_PRODUCTS_API_URL);
  return await response.json();
};

const getProduct = async (id) => {
  const response = await fetch(`${GET_PRODUCTS_API_URL}/${id}`);
  return await response.json();
};

export { getProducts, getProduct };
