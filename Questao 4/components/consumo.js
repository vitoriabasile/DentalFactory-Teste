import React from "react";

const BASE_URL = "https://cors-anywhere.herokuapp.com/https://tf378xyae1.execute-api.sa-east-1.amazonaws.com/prod/images";

class tela extends React.Component {
  state = {
    isLoaded: false,
    error: null,
    posts: []
  };

  componentDidMount() {
    this.setState({ isLoaded: true });
    fetch(BASE_URL)
      .then(res => {
        if (res.ok) {
          return res.json();
        } else {
          throw Error("Erro ao buscar os posts");
        }
      })
      .then(posts => {
        console.log(posts);
        this.setState({ posts, isLoaded: false });
      })
      .catch(error => {
        this.setState({ error });
      });
  }

  render() {
    const { error, isLoaded, posts } = this.state;

    if (error) {
      return <p className="error-message">{error.message}</p>;
    }


    if (isLoaded) {
      return <p className="loaded-message">Buscando posts...</p>;
    }


    return (
      <div className="app">
        <h1>Blog de tecnologia</h1>
        {posts.map(post => (

        

          <>
            <h3 className="title">
              <span>{post.id}  </span>
              {post.data}
              <br></br>
              {post.nome}
              <br></br>
              <picture>
        <source media="(width: 100px)" srcSet={post.url} />
        <source media="(width: 100px)" srcSet={post.url} />
        <source srcSet={post.url} />
        <img src={post.url} alt="{post.id}" height="200" width="200"/>
      </picture>
            </h3>
            <p className="body">{post.body}</p>
          </>
        ))}
      </div>
    );
  }
}

//const rootElement = document.getElementById("root");
//ReactDOM.render(<LoginScreen />, rootElement);
export default tela;