
document.body.style.margin = '0';
document.body.style.minHeight = '100vh';
document.body.style.display = 'flex';
document.body.style.justifyContent = 'center';
document.body.style.alignItems = 'center';
document.body.style.backgroundColor = '#2c2f33'; 
document.body.style.fontFamily = "'Segoe UI', Roboto, Helvetica, Arial, sans-serif";




function createElement(tag, styles = {}, text = '') {
    const el = document.createElement(tag);
    Object.assign(el.style, styles);
    if (text) el.innerHTML = text;
    return el;
}

const card = createElement('div', {
    backgroundColor: '#ffffff',
    width: '360px',
    borderRadius: '8px',
    boxShadow: '0 10px 20px rgba(0,0,0,0.2)',
    overflow: 'hidden',
    display: 'flex',
    flexDirection: 'column'
});


const imageWrapper = createElement('div', { position: 'relative', width: '100%', height: '220px' });

const houseImg = createElement('img', {
    width: '100%',
    height: '100%',
    objectFit: 'cover'
});

houseImg.src = 'https://images.unsplash.com/photo-1512917774080-9991f1c4c750?ixlib=rb-4.0.3&auto=format&fit=crop&w=800&q=80';


const heartIcon = createElement('div', {
    position: 'absolute',
    top: '15px',
    right: '15px',
    color: '#ffffff',
    fontSize: '24px',
    cursor: 'pointer',
    textShadow: '0 2px 4px rgba(0,0,0,0.4)'
}, '♡');

imageWrapper.appendChild(houseImg);

imageWrapper.appendChild(heartIcon);


const contentBox = createElement('div', { padding: '20px 20px 15px 20px' });

const propertyType = createElement('p', {
    color: '#64748b',
    fontSize: '11px',
    fontWeight: '700',
    letterSpacing: '0.5px',
    margin: '0 0 8px 0'
}, 'DETACHED HOUSE • 5Y OLD');

const price = createElement('h2', {
    color: '#0f172a',
    fontSize: '28px',
    fontWeight: '700',
    margin: '0 0 5px 0'
}, '$750,000');

const address = createElement('p', {
    color: '#64748b',
    fontSize: '14px',
    margin: '0'
}, '742 Evergreen Terrace');

contentBox.appendChild(propertyType);
contentBox.appendChild(price);
contentBox.appendChild(address);


const featuresBox = createElement('div', {
    display: 'flex',
    padding: '15px 20px',
    borderTop: '1px solid #e2e8f0',
    borderBottom: '1px solid #e2e8f0',
    gap: '24px'
});


const bedFeature = createElement('div', { display: 'flex', alignItems: 'center', gap: '8px' });
const bedIcon = createElement('span', { fontSize: '18px', color: '#64748b' }, '🛏️');
const bedText = createElement('span', { fontSize: '14px', color: '#334155', fontWeight: '600' }, '3 Bedrooms');
bedFeature.appendChild(bedIcon);
bedFeature.appendChild(bedText);


const bathFeature = createElement('div', { display: 'flex', alignItems: 'center', gap: '8px' });
const bathIcon = createElement('span', { fontSize: '18px', color: '#64748b' }, '🛁');
const bathText = createElement('span', { fontSize: '14px', color: '#334155', fontWeight: '600' }, '2 Bathrooms');
bathFeature.appendChild(bathIcon);
bathFeature.appendChild(bathText);

featuresBox.appendChild(bedFeature);
featuresBox.appendChild(bathFeature);

const realtorBox = createElement('div', { padding: '15px 20px 20px 20px' });

const realtorTitle = createElement('p', {
    color: '#64748b',
    fontSize: '11px',
    fontWeight: '700',
    letterSpacing: '0.5px',
    margin: '0 0 12px 0'
}, 'REALTOR');

const realtorInfo = createElement('div', { display: 'flex', alignItems: 'center', gap: '12px' });

const avatar = createElement('img', {
    width: '40px',
    height: '40px',
    borderRadius: '50%',
    objectFit: 'cover'
});

avatar.src = 'https://images.unsplash.com/photo-1573496359142-b8d87734a5a2?ixlib=rb-4.0.3&auto=format&fit=crop&w=100&q=80';

const realtorDetails = createElement('div', { display: 'flex', flexDirection: 'column' });
const realtorName = createElement('span', {
    color: '#0f172a',
    fontSize: '15px',
    fontWeight: '700',
    marginBottom: '2px'
}, 'Tiffany Heffner');

const realtorPhone = createElement('span', {
    color: '#64748b',
    fontSize: '13px'
}, '(555) 555-4321');

realtorDetails.appendChild(realtorName);
realtorDetails.appendChild(realtorPhone);

realtorInfo.appendChild(avatar);
realtorInfo.appendChild(realtorDetails);

realtorBox.appendChild(realtorTitle);
realtorBox.appendChild(realtorInfo);

// Bütün hissələri əsas karta yığırıq
card.appendChild(imageWrapper);
card.appendChild(contentBox);
card.appendChild(featuresBox);
card.appendChild(realtorBox);

document.body.appendChild(card);