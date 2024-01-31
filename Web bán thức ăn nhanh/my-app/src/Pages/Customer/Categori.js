import React, { useEffect, useState } from 'react';
import axiosClient from '../Component/axiosClient';
import {baseURL} from '../Component/axiosClient';
import OwlCarousel from 'react-owl-carousel';
import { Link, useNavigate } from 'react-router-dom';
import { useAuth } from '../Component/auth';
import { useParams } from "react-router-dom";

const Categori = () => {

    const [Products, setProducts] = useState([]);
    const [Combos, setCombos] = useState([]);
    const [ProductTypes, setProductTypes] = useState([]);
    const [currentPage, setCurrentPage] = useState(1);
    const [productsPerPage] = useState(6);
    const [isDataLoaded, setIsDataLoaded] = useState(false);
    const { id } = useParams();
    const navigate =  useNavigate();
    const {  userId } = useAuth();
    const [cart, setCart] = useState([]);
     useEffect(() => {
        axiosClient.get(`/ProductTypes`).then((res) => setProductTypes(res.data));
        axiosClient.get(`/Products/ByProductTypeId/${id}`).then((res) => {
        setProducts(res.data);
        setIsDataLoaded(true);
        }).catch((res) => {console.log('Không có dữ liệu');});
        axiosClient.get(`/Comboes/ByProductTypeId/${id}`).then((res) => {
          setCombos(res.data);
        }).catch((res) => {console.log('Không có dữ liệu');});
    }, [isDataLoaded]);
    
    let AllIitems = [...Products,...Combos];
    console.log("produc:",AllIitems);
    const indexOfLastProduct = currentPage * productsPerPage;
    const indexOfFirstProduct = indexOfLastProduct - productsPerPage;
    const currentProducts = AllIitems.slice(indexOfFirstProduct, indexOfLastProduct);
    const paginate = (pageNumber) => setCurrentPage(pageNumber);
    const totalPages = Math.ceil(AllIitems.length / productsPerPage);
    // Hàm xử lý trang trước
    const handlePrevPage = () => {
      if (currentPage > 1) {
        paginate(currentPage - 1);
      }
    };

    // Hàm xử lý trang sau
    const handleNextPage = () => {
      if (currentPage < totalPages) {
        paginate(currentPage + 1);
      }
    };

// Function to handle next page
    
    
    let carouselOptions = {
        loop: true,
        margin: 0,
        items: 1,
        dots: true,
        smartSpeed: 1200,
        autoplay: true,
        settimeout: 1000,
      };                                                                                        
// lấy dữ liệu giỏ hàng
      useEffect(() => {
        const fetchData = async () => {
            try {
                
                const cartResponse = await  axiosClient.get(`/Carts/userId`, {
                  params: { userId: encodeURIComponent(userId) }
              })
              setCart(cartResponse.data);
            } catch (error) {
                console.error('Lỗi khi lấy dữ liệu:', error);
            }
        };
    
        // Gọi hàm fetchData khi component được mount
        fetchData();
    }, [userId]);
    // xử lý thêm sản phẩm vào giỏ hàng
    const handleAddToCart =  (productId,productSku) => {
      
  
      //const cartItem = cart.find(a => a.product.id === productId);
      //const foundCartItem = cart.find(a => a.product.id === productId && a.combo.productType.name === comboName);
      let cartItem =null;
      if(productSku === undefined){
        cartItem = cart.find(a => a.comboId === productId);
      }else{
        cartItem = cart.find(a => a.productId === productId);
      }
      console.log('cartItem',cartItem)
  
      let foundProduct = false;
      
      if (cartItem) {
        
       
          let idP = cartItem.productId;
          let idC = cartItem.comboId;
          let id  = cartItem.id;
          if(idP  === productId && productSku !== undefined)
          {
            foundProduct =true;
            const updateItem = { ...cartItem, quantity: cartItem.quantity  + 1};
            try{
              const token = localStorage.getItem('token');
                
                axiosClient.put(`/Carts/${id}`, updateItem ,{
                  headers: {
                    'Authorization': `Bearer ${token}`,
                    'Content-Type': 'application/json',
                    // Các headers khác nếu cần thiết
                  },})
                .then(() => navigate('/Shop/cart'));
            }
            catch
            {
              console.log('lỗi khi thêm vào giỏ hàng')
            }
            
          }else if(idC  === productId && productSku === undefined)
          {
            foundProduct =true;
            const updateItem = { ...cartItem, quantity: cartItem.quantity  + 1};
            try{
              const token = localStorage.getItem('token');
                
                axiosClient.put(`/Carts/${id}`, updateItem ,{
                  headers: {
                    'Authorization': `Bearer ${token}`,
                    'Content-Type': 'application/json',
                    // Các headers khác nếu cần thiết
                  },})
                .then(() => navigate('/Shop/cart'));
            }
            catch
            {
              console.log('lỗi khi thêm vào giỏ hàng')
            }
          }
        }
  
          if (!foundProduct) {
            const cart = {
              userId: userId,
              productId: productSku !== undefined ? productId : null,
              ComboId: productSku !== undefined ? null :productId,
              quantity: 1
            };
            const token = localStorage.getItem('token');
            axiosClient.post(`/Carts`, cart,{
              headers: {
                'Authorization': `Bearer ${token}`,
                'Content-Type': 'application/json',
                // Các headers khác nếu cần thiết
              },})
              .then(() => {
                console.log('Product added successfully');
              })
              .catch((error) => {
                console.error('Error adding product to cart:', error);
                console.log('lỗi khi thêm vào giỏ hàng');
              });
          }
    };

    return ( 
      <>
    <section className="product spad">
      <div className="container">
        <div className="row">
          <div className="col-lg-3 col-md-5">
            <div className="sidebar">
              <div className="sidebar__item">
                <h4>Thực đơn</h4>
                <ul>
                    {ProductTypes.map
                    ((producttypes,index) =>(
                        <li key={index}>
                          <a href={`/Shop/categori/${producttypes.id}`}>
                            {producttypes.name}
                          </a>
                        </li>
                    ))
                    }
                </ul>
              </div>
              <div className="sidebar__item">
                <div className="latest-product__text">
                  <h4>Cập nhật mới</h4>
                  <OwlCarousel
                        className="latest-product__slider owl-carousel owl-loaded owl-drag"
                        {...carouselOptions}
                    >
                      {/* {console.log(Products)} */}
                      
                        {AllIitems.map((items, index) => (
                          
                        <div className="latest-prdouct__slider__item">
                            <a href={`/Shop/product/detail/${items.productType.name == "ComBo" ?
                                                             items.id+"&productTypeId="+items.productType.id 
                                                            :items.id
                                                            }`} className="latest-product__item">
                                <div className="latest-product__item__pic">
                                
                                
                                <img src={`${baseURL}/Images/${items.images.img}`} alt="Ảnh minh họa shop"/>
                                    
                                </div>
                                <div className="latest-product__item__text">
                                    <h6>{items.name}</h6>
                                    <span>{items.price.toLocaleString('vi-VN')}</span>
                                </div>
                            </a>
                        </div>
                        
                      ))}
                        
                    </OwlCarousel>
                </div>
              </div>
            </div>
          </div>
          <div className="col-lg-9 col-md-7">
            <div className="row">
              {/* Product items */}
              {/* Replace this section with your dynamic product items */}
              {currentProducts.map((product, index) => (
              <div key={index} className="col-lg-4 col-md-6 col-sm-6">
                <div className="product__item">
                  <div
                    className="product__item__pic set-bg"
                    data-setbg={`${baseURL}/Images/${product.images.img}`}
                    style={{ backgroundImage: `url(${baseURL}/Images/${product.images.img})` }}
                  >
                    <ul className="product__item__pic__hover">
                      <li>
                      <Link to={`/Shop/product/detail/${product.productType.name == "ComBo" ?
                                                            product.id+"&productTypeId="+product.productType.id :
                                                            product.id}`}>
                          <i className="fa fa-eye"></i>
                        </Link>
                      </li>
                      <li>
                      <Link
                        
                        onClick={() => handleAddToCart(product.id,product.sku)}
                      >
                          <i className="fa fa-shopping-cart"></i>
                        </Link>
                      </li>
                    </ul>
                  </div>
                  <div className="product__item__text">
                    <h6>
                      <Link to="#">{product.name}</Link>
                    </h6>
                    <h5>{product.price.toLocaleString('vi-VN')} vnđ</h5>
                  </div>
                </div>
              </div>
            ))}
              {/* Repeat the above block for other product items */}
            </div>
            <div className="product__pagination">
            <div className="pagination-container">
                <br/><br/>
              <ul className="pagination">
                
              <span className="pagination-container">
                <button className="pagination-button" onClick={handlePrevPage} disabled={currentPage === 1}>
                «
                </button>
                <span className="pagination-info">
                  {currentPage} / {totalPages}
                </span>
                <button className="pagination-button" onClick={handleNextPage} disabled={currentPage === totalPages}>
                »
                </button>
            </span>
              </ul>
            </div>
          </div>
          </div>
        </div>
      </div>
    </section>

    </> 
    );
}
 
export default Categori;