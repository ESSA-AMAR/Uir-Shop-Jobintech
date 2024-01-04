import flech from '../../assets/flech.png'
import tennu from '../../assets/tennu.png'
import { Link } from 'react-router-dom'
import heart from '../../assets/heart.png'
import axios from "axios";
import { useEffect, useState } from "react";

export default function NewListings() {
  const [data, setdata] = useState([]);

  useEffect(() => {
    axios
      .get("https://localhost:7089/api/Product")
      .then(function (response) {
        setdata(response.data);
      })
      .catch(function (res) {
        console.log(res);
      });
  }, []);

  useEffect(() => {
    console.log(data);
  }, [data]);

  
  return (
    <div>
    <div className='py-5  flex justify-between '>
      <h1 className='text-[#183761] font-semibold text-[25px]'>New Listings</h1>
      <Link to='/product/textile' className='flex  items-center gap-2 text-[#183761] font-semibold  text-[25px]'>See all <img src={flech} alt="" className='w-[50px]' /></Link>
    </div>
    <div className="bg-[#f3f3f2] w-full flex justify-between items-center py-8 px-8 rounded-3xl ">
        {data.slice(0, 4).map((product) => (
          <Link to={`/product/product-details/${product.id}`} className="cursor-pointer w-[20%]  mt-28 mb-3 rounded-3xl py-6 relative ">
            <img src={tennu} alt="" className="absolute top-[-120px]" />
            <div className="flex flex-col justify-between items-center bg-[#183761] pt-24 pb-6 rounded-[20px]">
              <h1 className="text-[#FFFFFF]">{product.price} MAD </h1>
              <h1 className="text-[#FFFFFF]">{product.productTitle}</h1>
              <p className="text-[#FFFFFF] text-center w-[80%] text-[12px] my-2">{product.productDescription}</p>
              <div className="flex justify-between gap-2 items-center my-2">
                <button className="text-[#FDFDFD] bg-[#C9CE19] py-2 px-8 text-center rounded-md">
                  Add To Card
                </button>
                <button className="text-[#183761] bg-[#C9CE19] py-2 px-2 text-center rounded-full">
                  <img src={heart} alt="" />{" "}
                </button>
              </div>
            </div>
            </Link>
        ))}
      </div>
  </div>
  )
}
