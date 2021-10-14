import '../styles/Category.css'

function Category({ setActiveCategory, categoryList, activeCategory }) {
    return (
        <div className="categories">
            <select name="Category" className='form-select'
                value={activeCategory}
                onChange={(e) => setActiveCategory(e.target.value)} >

                <option value='' >---</option>
                {categoryList.map((cat) => (
                    <option key={cat} value={cat}>
                        {cat}
                    </option>
                ))}
            </select>
            <button className='btn btn-secondary' onClick={() => setActiveCategory('')}>Rechercher</button>
        </div >
    )
}

export default Category
